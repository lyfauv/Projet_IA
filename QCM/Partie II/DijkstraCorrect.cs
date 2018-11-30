using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM.Partie_II
{
    public partial class DijkstraCorrect : Form
    {       
        public DijkstraCorrect(string img, int numinitial, int numfinal, TreeView treeView2)
        {
            InitializeComponent();

            //Affichage image
            pictureBox1.Image = Image.FromFile(img);

            //Afficher treeview
            treeView = treeView2; 
            

            

        }

        private void DijkstraCorrect_Load(object sender, EventArgs e)
        {

        }

        private void btn_Qt_Click(object sender, EventArgs e)
        {

        }
    }
}
