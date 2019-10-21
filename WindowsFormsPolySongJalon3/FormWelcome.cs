using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        #region déclartion nécessaires pour le compte à rebours
        private System.Windows.Forms.Timer aTimer;
        private int counter = 3;
        #endregion déclartion nécessaires pour le compte à rebours

        private void Welcome_Load(object sender, EventArgs e)
        {
            #region gestion de la modification de la taille de l'image affichée
            // Création d'une nouvelle image à la taille du container
            Bitmap finalImg = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            // Centre la nouvelle image
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            // Affecte la nouvelle image
            pictureBox1.Image = finalImg;

            // L'affiche
            pictureBox1.Show();
            #endregion gestion de la modification de la taille de l'image affichée

            #region gestion du compte à rebours

            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 1000; // 1 second
            aTimer.Start();
            #endregion gestion du compte à rebours

        }

        #region builtin fuctions
        // Fonction qui décrémente le compte à rebours
        private void aTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                aTimer.Stop();
                this.Dispose();
                FormActivity activity = new FormActivity();
                activity.MdiParent = FormMain.ActiveForm;
                activity.Show();
            }                
        }
        #endregion Builtin functions
    }
}
