using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormCarPooler : Form
    {
        #region constructeur
        /// <summary>
        /// Initialise les composants du formulaire.
        /// </summary>
        public FormCarPooler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise vues v_CarPooler_Activity, v_Assigned_CarPooler et les composants du formulaire.
        /// </summary>
        /// <param name="v_driver"></param>
        public FormCarPooler(cda07_bd1DataSet.v_Driver_ActivityRow v_driver) : this()
        {
            try
            {
                #region Initialisations des vues et attributs de classe
                v_Driver_ActivityRow = v_driver;
                // TODO: cette ligne de code charge les données dans la table 'cda07_bd1DataSet.v_CarPooler_Activity'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, v_driver.ID_ACTIVITE);
                v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, v_driver.ID_ADHERENT, v_driver.ID_ACTIVITE);
                Text += " - " + v_driver.PRENOM + " " + v_driver.NOM + " - " + v_driver.TITRE;
                places = v_driver.NOMBRE;
                #endregion Initialisations

                #region initialisation des textBox
                textBoxFirstName.Text = v_driver.PRENOM;
                textBoxLastName.Text = v_driver.NOM;
                textBoxPlaces.Text = v_driver.NOMBRE.ToString();
                #endregion initialisation des textBox
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion constructeur

        #region attributs privées de classe
        /// <summary>
        /// Le nombre de places mises à disposition par le chauffeur.
        /// </summary>
        private int _places;
        /// <summary>
        /// L'enregistrement courant du chauffeur sélectionné.
        /// </summary>
        private cda07_bd1DataSet.v_Driver_ActivityRow _v_driver;
        #endregion attributs privées

        #region accesseurs
        internal int places
        {
            get { return _places; }
            set { _places = value; }
        }

        internal cda07_bd1DataSet.v_Driver_ActivityRow v_Driver_ActivityRow
        {
            get { return _v_driver; }
            set { _v_driver = value; }
        }

        //internal List<CarPooler> listCarPooler
        //{
        //    get { return _listCarPooler; }
        //    set { _listCarPooler = value; }
        //}
        #endregion accesseurs

        #region FormCarPooler
        /// <summary>
        /// Met à jour la liste des adhérents dés que le formulaire est actif au cas ou des modifications
        /// ont été réalisées sur un autre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCarPooler_Activated(object sender, EventArgs e)
        {
            try
            {
                v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, v_Driver_ActivityRow.ID_ADHERENT, v_Driver_ActivityRow.ID_ACTIVITE);
                v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, v_Driver_ActivityRow.ID_ACTIVITE);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region dataGridView
        /// <summary>
        /// Ajoute l'adhèrent sélectionné au véhicule du chauffeur sélectionné.
        /// Puis enlève l'adhérent à la liste des adhérent souhaitant une place.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCarPooler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Teste si le Current est différent de null

            if (vCarPoolerActivityBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                cda07_bd1DataSet.v_CarPooler_ActivityRow v_CarPooler_Activity = (cda07_bd1DataSet.v_CarPooler_ActivityRow)((DataRowView)vCarPoolerActivityBindingSource.Current).Row;

                addCarPooler(v_CarPooler_Activity);
            }
        }

        /// <summary>
        /// Gestion de l'ajout d'un adhérent dans un véhicule par la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCarPooler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Teste si le Current est différent de null
                if (vCarPoolerActivityBindingSource.Current != null)
                {
                    // Récupération de l'enregistrement courant
                    cda07_bd1DataSet.v_CarPooler_ActivityRow v_CarPooler_Activity = (cda07_bd1DataSet.v_CarPooler_ActivityRow)((DataRowView)vCarPoolerActivityBindingSource.Current).Row;

                    // Teste la connexion avant de lancer la transaction
                    try
                    {
                        // Lance la transaction portant sur :
                        // 1) l'ajout d'un adhérent dans la table covoiturage 
                        // 2) la suppression dans la liste des adhérents en attente
                        addCarPooler(v_CarPooler_Activity);
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                    {

                        MessageBox.Show(Properties.Resources.TXT_ERRMYSQL,
                                        Properties.Resources.TITREERRMYSQL,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        #region listBoxCar
        /// <summary>
        /// Ajoute l'adhérent sélectionné dans la liste des adhérent souhaitant une place,
        /// puis l'enlève du véhicule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCar_DoubleClick(object sender, EventArgs e)
        {
            // Teste si le Current est différent de null
            if (vAssignedCarPoolerBindingSource.Current != null)
            {
                // Récupère le current en cours
                cda07_bd1DataSet.v_Assigned_CarPoolerRow v_AssignedCarPooler = (cda07_bd1DataSet.v_Assigned_CarPoolerRow)((DataRowView)vAssignedCarPoolerBindingSource.Current).Row;

                removeCarPooler(v_AssignedCarPooler);
            }
        }

        /// <summary>
        /// Gestion de la suppression d'un adhérent par la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Teste si le Current est différent de null
                if (vAssignedCarPoolerBindingSource.Current != null)
                {
                    // Récupère le current en cours
                    cda07_bd1DataSet.v_Assigned_CarPoolerRow v_AssignedCarPooler = (cda07_bd1DataSet.v_Assigned_CarPoolerRow)((DataRowView)vAssignedCarPoolerBindingSource.Current).Row;

                    removeCarPooler(v_AssignedCarPooler);
                } 
            }
        }
        #endregion listBoxCar

        #region Built-in functions
        /// <summary>
        /// Ajoute un adhérent à un véhicule
        /// </summary>
        private void addCarPooler(cda07_bd1DataSet.v_CarPooler_ActivityRow carPoolerActivity)
        {
            // Teste si il reste des places dans le véhicule
            if (listBoxCar.Items.Count < places)
            {
                // Utilisation d'une transaction
                using (TransactionScope trans = new TransactionScope())
                {
                    #region Ajout de l'adhérent dans la voiture courante
                    // Dans la table des covoiturages
                    // @p1 chauffeur, @p2 covoitureur, @p3 activité
                    int InsertCovoiturage = covoiturageTableAdapter.Insert(v_Driver_ActivityRow.ID_ADHERENT, 
                                                                           carPoolerActivity.ID_ADHERENT, 
                                                                           v_Driver_ActivityRow.ID_ACTIVITE);

                    // Et dans la table souhaite_une_place
                    // @p1 adhérent, @p2 activité. 
                    int DeleteSouhaite = souhaite_une_placeTableAdapter.Delete(carPoolerActivity.ID_ADHERENT, 
                                                                               v_Driver_ActivityRow.ID_ACTIVITE);

                    // Teste si les ajouts se sont bien passés
                    if (InsertCovoiturage == 0)                 // Pas effectué sur les coivoiturage
                    {
                        //Message d'erreur fait un rollback
                        MessageBox.Show(String.Format(Properties.Resources.TEXT_INSCOVOITURAGE_ERR, v_Driver_ActivityRow.PRENOM + " " + v_Driver_ActivityRow.NOM), Properties.Resources.COVOITURAGE_INS_ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (DeleteSouhaite == 0)
                    {
                        //Message d'erreur fait un rollback
                        MessageBox.Show(String.Format(Properties.Resources.TEXT_INSCOVOITURAGE_ERR, v_Driver_ActivityRow.PRENOM + " " + v_Driver_ActivityRow.NOM), Properties.Resources.COVOITURAGE_INS_ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Fait un commit
                        trans.Complete();
                    }
                }

                // Teste de connexion avant les appels des méthodes Fill
                try
                {
                    // Met à jour des vues
                    v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, 
                                                                    v_Driver_ActivityRow.ID_ACTIVITE);
                    v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, 
                                                                          v_Driver_ActivityRow.ID_ADHERENT, 
                                                                          v_Driver_ActivityRow.ID_ACTIVITE);
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                    MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, 
                                    Properties.Resources.TITREERRMYSQL, 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                }
                #endregion Ajout de l'adhérent dans la voiture courante
            }

            // Affiche un message d'erreur
            else
            {
                MessageBox.Show(Properties.Resources.TXT_ERRADDCOVOIT, Properties.Resources.TITRE_ERRADDCOVOIT);
            }
        }

        /// <summary>
        /// Enlève un adhérent d'un véhicule
        /// </summary>
        private void removeCarPooler(cda07_bd1DataSet.v_Assigned_CarPoolerRow carPooler)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                // Supprime dans la table des coivoiturage l'adhérent selectionné
                int DeleteCovoiturage = covoiturageTableAdapter.Delete(carPooler.CHAUFFEUR, 
                                                                       carPooler.COVOITUREUR, 
                                                                       carPooler.ACTIVITE);

                // Le rajoutera dans la table souhaite_une_place
                int InsertSouhaite = souhaite_une_placeTableAdapter.Insert(carPooler.COVOITUREUR, 
                                                                           carPooler.ACTIVITE);

                //Message d'erreur fait un rollback
                if (DeleteCovoiturage == 0)
                {
                    //Message d'erreur fait un rollback
                }

                //Message d'erreur fait un rollback
                else if (InsertSouhaite == 0)
                {
                    //Message d'erreur fait un rollback
                }
                else
                {
                    // Fait un commit
                    trans.Complete();
                }
            }

            try
            {
                // Met à jour les tables et vues impactées
                covoiturageTableAdapter.Fill(cda07_bd1DataSet.covoiturage);
                souhaite_une_placeTableAdapter.Fill(cda07_bd1DataSet.souhaite_une_place);
                v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, carPooler.ACTIVITE);
                v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, carPooler.CHAUFFEUR, carPooler.ACTIVITE);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Built-in functions
    }
}
