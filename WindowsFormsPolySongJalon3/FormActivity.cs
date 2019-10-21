using System;
using System.Transactions;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormActivity : Form
    {
        #region Attributs privés
        cda07_bd1DataSet.activiteRow _activityRow;

        #region Attributs privés nécessaires à la création du rapport
        private Paragraph _PTitle;
        private Paragraph _PPlace;
        private Paragraph _PDate;
        private Phrase _titleDataGridViewDriver;
        private Phrase _titleDataGridViewCarPooler;
        private PdfPTable _pdfPTableDriver;
        private PdfPTable _pdfPTableCarPooler;
        private iTextSharp.text.Font _textFont;
        private List _driverList;
        private List _carPoolerList;
        #endregion Attributs privés nécessaires à la création du rapport

        #endregion Attributs privés

        #region Accesseurs
        private cda07_bd1DataSet.activiteRow activityRow
        {
            get { return _activityRow; }
            set { _activityRow = value; }
        }

        #region Accesseurs nécessaires à la création du rapport
        private List carPoolerList
        {
            get { return _carPoolerList; }
            set { _carPoolerList = value; }
        }

        private List driverList
        {
            get { return _driverList; }
            set { _driverList = value; }
        }

        private Paragraph PTitle
        {
            get { return _PTitle; }
            set { _PTitle = value; }
        }

        private Paragraph PPlace
        {
            get { return _PPlace; }
            set { _PPlace = value; }
        }

        private Paragraph PDate
        {
            get { return _PDate; }
            set { _PDate = value; }
        }

        private Phrase titleDataGridViewDriver
        {
            get { return _titleDataGridViewDriver; }
            set { _titleDataGridViewDriver = value; }
        }

        private Phrase titleDataGridViewCarPooler
        {
            get { return _titleDataGridViewCarPooler; }
            set { _titleDataGridViewCarPooler = value; }
        }

        private PdfPTable pdfTableDriver
        {
            get { return _pdfPTableDriver; }
            set { _pdfPTableDriver = value; }
        }

        private PdfPTable pdfTableCarPooler
        {
            get { return _pdfPTableCarPooler; }
            set { _pdfPTableCarPooler = value; }
        }

        private iTextSharp.text.Font textFont
        {
            get { return _textFont; }
            set { _textFont = value; }
        }
        #endregion Accesseurs nécessaires à la création du rapport

        #endregion Accesseurs

        #region constructeur
        /// <summary>
        /// Initialisation des composants du formulaire et remplissage de la table des activités
        /// avec les actitivités à venir nécessitant un covoiturage.
        /// </summary>
        public FormActivity()
        {
            InitializeComponent();

            try
            {
                // Remplissage de la table activite
                activiteTableAdapter.Fill(cda07_bd1DataSet.activite);

                // Teste si le Current est différent de null
                if (activiteBindingSource.Current != null)
                {
                    // Récupération de l'enregistrement courant
                    activityRow = (cda07_bd1DataSet.activiteRow)((DataRowView)activiteBindingSource.Current).Row;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion constructeur

        #region FormActivity
        /// <summary>
        /// Mise à jour du formulaire si celui-ci est actif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormActivity_Activated(object sender, EventArgs e)
        {
            // Teste si le Current est différent de null
            if (activiteBindingSource.Current != null)
            {
                UpadateNeeded();
            }
        }
        #endregion

        #region Menu
        /// <summary>
        /// Création du rapport de covoiturage relatif à l'activité en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Teste si le Current est différent de null
            if (activiteBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                activityRow = (cda07_bd1DataSet.activiteRow)((DataRowView)activiteBindingSource.Current).Row;

                string user = Environment.UserName;
                string path = @"C:\Users\" + user + @"\Desktop\";

                string fileName = activityRow.TITRE + ".pdf";
                string driverInfo = string.Empty;

                // Récupération de l'enregistrement courant de l'activité
                DataRowView activity = (DataRowView)activiteBindingSource.Current;

                // Exporte la ligne courante de l'activité
                DataRowViewToPdf(activity, textBoxDate.Text, fileName);

                try
                {
                    // Récupération des chauffeurs pour l'activité sélectionnée
                    v_Driver_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_Driver_Activity, activityRow.ID_ACTIVITE);

                    // Récupération des adhèrents souhaitant un covoiturage
                    v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, activityRow.ID_ACTIVITE);

                    // Exporte le dataGridViewDriver
                    GridViewToPdf(dataGridViewDriver, fileName);

                    // Exporte la vue portant sur les chauffeurs et celle sur les covoitureurs
                    // pour en faire une liste imbriquée
                    MakeDriverList(cda07_bd1DataSet.v_Driver_Activity.Rows);

                    // Teste si le dataGridViewCarPooler contient des données
                    if (dataGridViewCarPooler.Rows.Count > 0)
                    {
                        // Exporte le dataGridViewCarPooler
                        GridViewToPdf(dataGridViewCarPooler, fileName);
                    }

                    // Création du fichier Pdf
                    CreatePdf(fileName);

                    System.Diagnostics.Process.Start(fileName);
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                    MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Attribnution automatique des adhérents à une activité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attibuerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int freePlaces;
            int assignePlaces;
            int freeCarPooler;

            // Récupération de l'enregistrement courant
            cda07_bd1DataSet.activiteRow activity = (cda07_bd1DataSet.activiteRow)((DataRowView)activiteBindingSource.Current).Row;

            try
            {
                v_Driver_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_Driver_Activity, activity.ID_ACTIVITE);

                foreach (DataRow driver in cda07_bd1DataSet.v_Driver_Activity.Rows)
                {
                    // Récupère les adhérents qui lui sont déjà attribués
                    v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, Convert.ToInt16(driver["ID_ADHERENT"]), activity.ID_ACTIVITE);
                    // Récupére les adhérents en attente de covoiturage
                    v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, activity.ID_ACTIVITE);
                    // Le nombre de places attribuées
                    assignePlaces = cda07_bd1DataSet.v_Assigned_CarPooler.Count;
                    // Le nombre d'adhèrents en attente de covoiturage
                    freeCarPooler = cda07_bd1DataSet.v_CarPooler_Activity.Count;
                    // Le nombre de places restantes
                    freePlaces = Convert.ToInt16(driver["NOMBRE"]) - assignePlaces;
                    
                    int place = 0;

                    // Teste 
                    //  1) si la vue contient des enregistrement 
                    //  2) que le nombre de places n'est pas atteind
                    while (freeCarPooler != 0 && freePlaces != 0)
                    {

                        // Ajoute l'adhérent dans le véhicule
                        if (freeCarPooler > 1)
                        {
                            addCarPooler(driver, Convert.ToInt16(cda07_bd1DataSet.v_CarPooler_Activity.Rows[place]["ID_ADHERENT"]));

                        }
                        else
                        {
                            addCarPooler(driver, Convert.ToInt16(cda07_bd1DataSet.v_CarPooler_Activity.Rows[0]["ID_ADHERENT"]));
                        }

                        place++;
                        assignePlaces++;
                        freeCarPooler--;
                        freePlaces--;                          
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Mise à jour des informations sur l'activité
            UpadateNeeded();
            // Affiche un message d'information indiquant que l'attribution s'est bien passée
            MessageBox.Show(string.Format(Properties.Resources.TXT_ASSIGNEMENT, activity.TITRE), Properties.Resources.TITRE_ASSIGNMENT, MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }
        #endregion Menu

        #region dataGridViewActivity
        /// <summary>
        /// Lie au changement de selection du dataGridView à la mise  à jour les contrôles liés du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewActivity_SelectionChanged(object sender, EventArgs e)
        {
            // Teste si le Current est différent de null
            if (activiteBindingSource.Current != null)
            {
                UpadateNeeded();
            }
        }

        /// <summary>
        /// Lie l'ouverture du formulaire des chauffeurs à la selection de l'activité.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewActivity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Teste si le Current est différent de null
            if (activiteBindingSource.Current != null)
            {
                OpenDriverForm();
            }
        }

        /// <summary>
        /// Gestion de la sélection de l'activité par la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Teste si le Current est différent de null
                if (activiteBindingSource.Current != null)
                {
                    OpenDriverForm();
                }
            }
        }
        #endregion dataGridViewActivity

        #region builtin function
        /// <summary>
        /// Lance le formulaire représentant les chauffeurs affiliés à cette activité
        /// </summary>
        private void OpenDriverForm()
        {
            // Récupération de l'enregistrement courant
            activityRow = (cda07_bd1DataSet.activiteRow)((DataRowView)activiteBindingSource.Current).Row;
            #region instanciation du formulaire des conducteurs
            FormDriver driver = new FormDriver(activityRow.ID_ACTIVITE, activityRow.TITRE);
            driver.MdiParent = FormMain.ActiveForm;
            #region initialisation du formulaire driver

            #endregion initialisation du formulaire driver
            driver.Show();
            #endregion instanciation du formulaire des conducteurs 
        }

        /// <summary>
        /// Met à jour les contrôles liés du formulaire
        /// </summary>
        private void UpadateNeeded()
        {
            // Récupération de l'enregistrement courant
            cda07_bd1DataSet.activiteRow activity = (cda07_bd1DataSet.activiteRow)((DataRowView)activiteBindingSource.Current).Row;
            int? num = Convert.ToInt16(activity.ID_ACTIVITE);
            sUM_CAR_POOLERTableAdapter.GetData(num, out int? Sum_Car_Pooler);
            textBoxNeededPlaces.Text = Sum_Car_Pooler.ToString();
            assigneD_CAR_POOLERTableAdapter.GetData(num, out int? Assigned_Car_Pooler);
            textBoxUpsetPlaces.Text = Assigned_Car_Pooler.ToString();
            freE_CAR_POOLER_PLACESTableAdapter.GetData(num, out int? Free_Car_Pooler);
            textBoxPlacesToAttend.Text = Free_Car_Pooler.ToString();
        }

        /// <summary>
        /// Procédure qui ajoute un adhérent adans le véhicule, puis l'enléve de la liste des adhérents
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="carPooler"></param>
        private void addCarPooler(DataRow driver, int carPooler)
        {
            // Utilisation d'une transaction
            using (TransactionScope trans = new TransactionScope())
            {
                #region Ajout de l'adhérent dans la voiture courante
                // Dans la table des covoiturages
                // @p1 chauffeur, @p2 covoitureur, @p3 activité
                int InsertCovoiturage = covoiturageTableAdapter.Insert(Convert.ToInt16(driver["ID_ADHERENT"]), carPooler, Convert.ToInt16(driver["ID_ACTIVITE"]));

                // Et dans la table souhaite_une_place
                // @p1 adhérent, @p2 activité. 
                int DeleteSouhaite = souhaite_une_placeTableAdapter.Delete(carPooler, Convert.ToInt16(driver["ID_ACTIVITE"]));

                // Teste si les ajouts se sont bien passés
                if (InsertCovoiturage == 0)                 // Pas effectué sur les coivoiturage
                {
                    //Message d'erreur fait un rollback
                    MessageBox.Show(String.Format(Properties.Resources.TEXT_INSCOVOITURAGE_ERR, driver["PRENOM"].ToString() + " " + driver["NOM"].ToString()), Properties.Resources.COVOITURAGE_INS_ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DeleteSouhaite == 0)
                {
                    //Message d'erreur fait un rollback
                    MessageBox.Show(String.Format(Properties.Resources.TEXT_INSCOVOITURAGE_ERR, driver["PRENOM"].ToString() + " " + driver["PRENOM"].ToString()), Properties.Resources.COVOITURAGE_INS_ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Fait un commit
                    trans.Complete();
                }
            }

            try
            {
                // Met à jour des vues
                v_CarPooler_ActivityTableAdapter.FillByActivity(cda07_bd1DataSet.v_CarPooler_Activity, Convert.ToInt16(driver["ID_ACTIVITE"]));
                v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, Convert.ToInt16(driver["ID_ADHERENT"]), Convert.ToInt16(driver["ID_ACTIVITE"]));
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion Ajout de l'adhérent dans la voiture courante
        }

        #region fonctions nécessaires à la création du rapport
        #region MakeDriverList
        /// <summary>
        /// Fonction qui convertit une DataRowCollection en liste dans le rapport Pdf
        /// </summary>
        /// <param name="drivers"></param>
        private void MakeDriverList(DataRowCollection drivers)
        {
            try
            {
                driverList = new List(List.UNORDERED);
                carPoolerList = new List(List.NUMERICAL);

                // Boucle à travers les chauffeurs
                foreach (DataRow driver in drivers)
                {
                    carPoolerList = new List(List.NUMERICAL);
                    string driverInfo = driver["NOM"] + " " + driver["PRENOM"] + " nombre de place à disposition : " + driver["NOMBRE"];
                    driverList.Add(driverInfo);

                    // Sélectionne les adhérents affiliés à ce chauffeur
                    v_Assigned_CarPoolerTableAdapter.FillByDriverActivity(cda07_bd1DataSet.v_Assigned_CarPooler, Convert.ToInt16(driver["ID_ADHERENT"]), Convert.ToInt16(driver["ID_ACTIVITE"]));

                    // Boucle à travers les covoitureurs
                    foreach (DataRow carPooler in cda07_bd1DataSet.v_Assigned_CarPooler.Rows)
                    {
                        carPoolerList.IndentationLeft = 30f;
                        string carPoolerInfo = carPooler["PERSONNE"].ToString();
                        carPoolerList.Add(carPoolerInfo);
                    }

                    // Ajoute la liste des covoitureurs au chauffeur en cour
                    driverList.Add(carPoolerList);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                MessageBox.Show(Properties.Resources.TXT_ERRMYSQL, Properties.Resources.TITREERRMYSQL, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
        #endregion MakeDriverList

        /// <summary>
        /// Procédure qui convertit un DataRowView pour la création de l'intitulé du rapport
        /// </summary>
        /// <param name="current"></param>
        /// <param name="sDate"></param>
        /// <param name="fileName"></param>
        #region DataRowViewToPdf
        public void DataRowViewToPdf(DataRowView current, string sDate, string fileName)
        {
            BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            textFont = new iTextSharp.text.Font(font, 50, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Font text = new iTextSharp.text.Font(font, 10, iTextSharp.text.Font.NORMAL);

            Phrase title = new Phrase("Rapport de covoiturage\n" + current["TITRE"].ToString() + "\n");

            textFont = new iTextSharp.text.Font(font, 10, iTextSharp.text.Font.NORMAL);
            Phrase place = new Phrase("Lieu : " + current["LIEU"].ToString() + "\n");
            Phrase date = new Phrase("Date : " + sDate + "\n");


            PTitle = new Paragraph();
            PTitle.Alignment = Element.ALIGN_CENTER;
            PTitle.SpacingBefore = 100f;
            PTitle.SpacingAfter = 100f;
            PTitle.Add(title);
            PPlace = new Paragraph();
            PPlace.Alignment = Element.ALIGN_LEFT;
            PPlace.Add(place);
            PDate = new Paragraph();
            PDate.Alignment = Element.ALIGN_RIGHT;
            PDate.Add(date);
        }
        #endregion DataRowViewToPdf

        #region GridViewToPdf
        /// <summary>
        /// GridViewToPdf,fonction qui ajoute le contenu d'un DataGridView dans un fichier pdf.
        /// </summary>
        /// <param name="gridView">Le DataGridView a exporter.</param>
        /// <param name="fileName">Le nom du fichier pdf.</param>
        private void GridViewToPdf(DataGridView gridView, string fileName)
        {
            BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            iTextSharp.text.Font text = new iTextSharp.text.Font(font, 10, iTextSharp.text.Font.NORMAL);

            string subString = string.Empty;

            switch (gridView.Name)
            {
                case "dataGridViewDriver":
                    pdfTableDriver = new PdfPTable(gridView.Columns.Count);
                    pdfTableDriver.DefaultCell.Padding = 3;
                    pdfTableDriver.WidthPercentage = 100;
                    pdfTableDriver.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTableDriver.DefaultCell.BorderWidth = 1;

                    subString = "chauffeurs";
                    titleDataGridViewDriver = new Phrase("Liste des " + subString + " pour cette activité :");
                    // Ajoute une en-tête
                    CreateHeaderTable(gridView);
                    // Ajoute les lignes du DataGirdView
                    AddTableRows(gridView);

                    break;
                case "dataGridViewCarPooler":
                    pdfTableCarPooler = new PdfPTable(gridView.Columns.Count);
                    pdfTableCarPooler.DefaultCell.Padding = 3;
                    pdfTableCarPooler.WidthPercentage = 100;
                    pdfTableCarPooler.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTableCarPooler.DefaultCell.BorderWidth = 1;

                    subString = "covoitureurs en attente de place";
                    titleDataGridViewCarPooler = new Phrase("Liste des " + subString + " pour cette activité :");
                    // Ajoute une en-tête
                    CreateHeaderTable(gridView);
                    // Ajoute les lignes du DataGirdView
                    AddTableRows(gridView);
                    break;
                default:
                    break;
            }
        }
        #endregion GridViewToPdf

        #region CreateHeaderTable
        /// <summary>
        /// Procédure qui crée l'en tête du tableau résultant d'un  DataGridView
        /// </summary>
        /// <param name="gridView"></param>
        private void CreateHeaderTable(DataGridView gridView)
        {
            foreach (DataGridViewColumn column in gridView.Columns)
            {
                switch (gridView.Name)
                {
                    case "dataGridViewDriver":
                        PdfPCell cellDriver = new PdfPCell(new Phrase(column.HeaderText, textFont));
                        cellDriver.BackgroundColor = new iTextSharp.text.BaseColor(Color.LightGray);
                        pdfTableDriver.AddCell(cellDriver);
                        break;
                    case "dataGridViewCarPooler":
                        PdfPCell cellCarPooler = new PdfPCell(new Phrase(column.HeaderText, textFont));
                        cellCarPooler.BackgroundColor = new iTextSharp.text.BaseColor(Color.LightGray);
                        pdfTableCarPooler.AddCell(cellCarPooler);
                        break;
                    default:
                        break;
                }

            }
        }
        #endregion CreateHeaderTable

        /// <summary>
        /// Procédure qui ajoute les lignes du tableau
        /// </summary>
        /// <param name="gridView"></param>
        #region AddTableRows
        private void AddTableRows(DataGridView gridView)
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    switch (gridView.Name)
                    {
                        case "dataGridViewDriver":
                            pdfTableDriver.AddCell(new Phrase(cell.Value.ToString(), textFont));
                            break;
                        case "dataGridViewCarPooler":
                            pdfTableCarPooler.AddCell(new Phrase(cell.Value.ToString(), textFont));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        #endregion AddTableRows

        #region CreatePdf
        /// <summary>
        /// Procédure qui assemble les divers parties du rapport et le créer.
        /// </summary>
        /// <param name="fileName"></param>
        private void CreatePdf(string fileName)
        {
            string user = Environment.UserName;
            string path = @"C:\Users\" + user + @"\Desktop\";

            using (FileStream file = File.Create(fileName))
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(document, file);
                document.Open();
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.newlogoPSg, System.Drawing.Imaging.ImageFormat.Jpeg);
                logo.Alignment = Element.ALIGN_CENTER;
                logo.ScalePercent(50f);
                Paragraph PLogo = new Paragraph();
                PLogo.Add(logo);
                PLogo.Alignment = Element.ALIGN_CENTER;
                document.Add(PLogo);
                document.Add(PTitle);
                document.Add(PPlace);
                document.Add(PDate);
                document.Add(titleDataGridViewDriver);
                pdfTableDriver.SpacingAfter = 100f;
                document.Add(pdfTableDriver);
                document.Add(driverList);

                if (dataGridViewCarPooler.Rows.Count > 0)
                {
                    document.Add(titleDataGridViewCarPooler);
                    document.Add(pdfTableCarPooler); 
                }

                document.Close();
            }
        }
        #endregion CreatePdf

        #endregion fonctions nécessaires à la création du rapport

        #endregion

    }
}
