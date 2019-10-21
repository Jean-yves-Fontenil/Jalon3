using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPolySongJalon3
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            #region gestion de la modification de la taille de l'image affichée
            // Création d'une nouvelle image à la taille du container

            Bitmap finalImg = new Bitmap(pictureBoxAbout.Image, pictureBoxAbout.Width, pictureBoxAbout.Height);

            // Centre la nouvelle image
            pictureBoxAbout.SizeMode = PictureBoxSizeMode.CenterImage;

            // Affecte la nouvelle image
            pictureBoxAbout.Image = finalImg;

            // L'affiche
            pictureBoxAbout.Show();
            labelEditor.Text += Application.CompanyName;
            // Applique le nom du produit et la version du Build au textBox concerné
            labelVersion.Text += " version " + Application.ProductVersion;
            #endregion gestion de la modification de la taille de l'image affichée
        }
    }
}
