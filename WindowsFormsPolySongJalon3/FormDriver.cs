using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormDriver : Form
    {
        #region constructeur
        /// <summary>
        /// Initialise les composants du formulaire.
        /// </summary>
        public FormDriver()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise les composants du formulaire, sélectionne les chauffeur pour une activité et en 
        /// affiche son titre.
        /// </summary>
        /// <param name="activity">L'activité sélectionnée.</param>
        /// <param name="title">Son titre</param>
        public FormDriver(int activity, string title):this()
        {
            try
            {
                v_Driver_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_Driver_Activity, activity);
                Text += " - " + title;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion constructeur

        #region attributs de classe
        /// <summary>
        /// Le chauffeur sélectionné.
        /// </summary>
        private int _driver;
        /// <summary>
        /// L'activité sectionnée.
        /// </summary>
        private int _activity;
        #endregion attributs de classe

        #region Accesseurs
        internal int driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        internal int activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
        #endregion Accesseurs

        #region FormDriver
        /// <summary>
        /// Met à jpur le nombre de places assignées si le formulaire des chauffeur a le focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDriver_Activated(object sender, EventArgs e)
        {
            textBoxPlacesAssigned.Text = v_Assigned_CarPoolerTableAdapter.CountAssignedPlaces(driver, activity).ToString();
            textBoxToBeAssigned.Text = (Convert.ToInt16(textBoxPlaces.Text) - Convert.ToInt16(textBoxPlacesAssigned.Text)).ToString();
        }
        #endregion

        #region dataGridViewDriver
        /// <summary>
        /// Affecte les attributs de classe avec ID du chauffeur et ID de l'activité sélectionnés.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDriver_SelectionChanged(object sender, EventArgs e)
        {
            // Test si le Current est null
            if (vDriverActivityBindingSource.Current != null)
            {
                //Récupération de l'enregistrement courant
                cda07_bd1DataSet.v_Driver_ActivityRow v_driver = (cda07_bd1DataSet.v_Driver_ActivityRow)((DataRowView)vDriverActivityBindingSource.Current).Row;

                #region Affectation des attributs de classe
                driver = v_driver.ID_ADHERENT;
                activity = v_driver.ID_ACTIVITE;
                #endregion Affectation des attributs de classe

                #region Initialisation des TextBox
                textBoxPlacesAssigned.Text = v_Assigned_CarPoolerTableAdapter.CountAssignedPlaces(driver, activity).ToString();
                //textBoxToBeAssigned.Text = freePlaces.ToString();
                #endregion Initialisation des TextBox
            }
        }

        /// <summary>
        /// Affiche le formulaire des covoitureurs en attente d'attribution avec ID du chauffeur sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDriver_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Test si le Current est null
            if (vDriverActivityBindingSource.Current != null)
            {
                openDriversForm();
            }
        }

        /// <summary>
        /// Validation de la sélection du chauffeur par la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDriver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openDriversForm();
            }
        }
        #endregion dataGridViewDriver

        #region built-in function
        /// <summary>
        /// Ouvre le formulaire le formulaire sur les chauffeurs
        /// </summary>
        private void openDriversForm()
        {
            //Récupération de l'enregistrement courant
            cda07_bd1DataSet.v_Driver_ActivityRow v_driver = (cda07_bd1DataSet.v_Driver_ActivityRow)((DataRowView)vDriverActivityBindingSource.Current).Row;

            //textBoxPlacesAssigned.Text = v_Assigned_CarPoolerTableAdapter.CountAssignedPlaces(driver, activity).ToString();
            #region instanciation du formulaire des covoitureurs
            FormCarPooler carPooler = new FormCarPooler(v_driver);
            carPooler.MdiParent = FormMain.ActiveForm;
            carPooler.Show();
            #endregion instanciation du formulaire des coivoitureurs
        }
        #endregion built-in function
    }
}
