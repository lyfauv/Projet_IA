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
        public DijkstraCorrect(string img, int numinitial, int numfinal)
        {
            InitializeComponent();

            //Affichage image
            pictureBox1.Image = Image.FromFile(img);

            //Affichage noeud initial et final
            labelNdInit.Text = numinitial.ToString();
            labelNdFinal.Text = numfinal.ToString();

            //Afficher treeview
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            List<GenericNode> solution;
            N0.numero = numinitial;
            solution = g.RechercheSolutionAEtoile(N0);
            g.GetSearchTree(treeView);

            // Affichage des noeuds ouverts et fermés
            for (int j = 0; j < g.L_Etats.GetLength(0); j++)
            {
                if (g.L_Etats[j, 0] != null)
                {
                    listBox_NdO.Items.Add(g.AfficheListeNoeuds(g.L_Etats[j, 0]).ToString());
                }

                if (g.L_Etats[j, 1] != null)
                {
                    listBox_NdF.Items.Add(g.AfficheListeNoeuds(g.L_Etats[j, 1]).ToString());
                }
            }
        }
        
        private void btn_Qt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
