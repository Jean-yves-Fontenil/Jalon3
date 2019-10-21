using System;
using System.Windows.Forms;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormMain : Form
    {
        #region constructeur
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion constructeur

        #region FormMain
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormWelcome start = new FormWelcome();
            start.MdiParent = this;
            start.Show();
        }
        #endregion

        #region Menu
        /// <summary>
        /// Lance le formulaire des activités.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void activitésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormActivity activity = new FormActivity();
            activity.MdiParent = this;
            activity.Show();
        }

        ///<summary>
        /// Quitte l'application en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Réorganise les formulaires enfants en cascade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        /// <summary>
        /// Réorganise les formulaires enfants en mosaïque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mosaïqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        /// <summary>
        /// Affichage du formulaire A-propos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.MdiParent = this;
            about.Show();
        }
        #endregion Menu
        
    }
}
