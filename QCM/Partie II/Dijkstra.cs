using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM.Partie_II
{
    public partial class Dijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes;
        static public string img;
        static public int numinitial;
        static public int numfinal;
        static public string[,] t_JoueurNd, t_OrdinateurNd;
        List<GenericNode> solution;
        SearchTree g = new SearchTree();

        public Dijkstra()
        {
            InitializeComponent();
        }

        private void button_Init_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(1, 3);
            string txt = "../../graphe" + num + ".txt";

            StreamReader monStreamReader = new StreamReader(txt);

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes + 1, nbnodes + 1];
            for (int k = 0; k <= nbnodes; k++)
                for (int j = 0; j <= nbnodes; j++)
                    matrice[k, j] = -1;

            // Affichage aléatoire du noeud initial à explorer
            labelNdInit.Text = (r.Next(1, nbnodes + 1).ToString());

            // Affichage aléatoire du noeud final
            do
            {
                labelNdFinal.Text = (r.Next(1, nbnodes + 1).ToString());
            } while (labelNdFinal.Text == labelNdInit.Text);

            // 2ème ligne : image associée
            ligne = monStreamReader.ReadLine();
            i = 0;
            while (ligne[i] != ':') i++;
            img = "../../";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                img = img + ligne[i];
                i++;
            }

            // Ensuite on a les tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe1.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();

            //Affichage image
            pictureBox1.Image = Image.FromFile(img);

            for (int m = 1; m < nbnodes + 1; m++)
            {
                checkedListBox_NdO.Items.Add(m);
            }

            for (int m = 1; m < nbnodes + 1; m++)
            {
                checkedListBox_NdF.Items.Add(m);
            }

            listBox_NdO.Items.Clear();

            // Affichage du premier noeud à explorer
            listBox_NdO.Items.Add(labelNdInit.Text + "; ");
            listBox_NdF.Items.Add(" ");


            // Affichage arbre vide
            numinitial = Convert.ToInt32(labelNdInit.Text);
            numfinal = Convert.ToInt32(labelNdFinal.Text);
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            solution = g.RechercheSolutionAEtoile(N0);

            g.GetSearchTreeVoid(treeView1);
            // Affichage arbre rempli caché 
            g.GetSearchTree(treeView2);

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {

            // On transfère les items sélectionnés à la liste
            string sNdO = "";
            for (int m = 0; m < checkedListBox_NdO.CheckedItems.Count; m++)
            {
                sNdO = sNdO + checkedListBox_NdO.CheckedItems[m] + "; ";
            }
            listBox_NdO.Items.Add(sNdO);

            string sNdF = "";
            for (int m = 0; m < checkedListBox_NdF.CheckedItems.Count; m++)
            {
                sNdF = sNdF + checkedListBox_NdF.CheckedItems[m] + "; ";
            }
            listBox_NdF.Items.Add(sNdF);

            // On clear les items sélectionnés dans la checkboxlist des noeuds ouverts
            foreach (int i in checkedListBox_NdO.CheckedIndices)
            {
                checkedListBox_NdO.SetItemCheckState(i, CheckState.Unchecked);
            }

            // Construction d'un tableau avec les états des noeuds choisis par le joueur
            t_JoueurNd = new string[listBox_NdO.Items.Count, 2];

            for (int i = 0; i < listBox_NdO.Items.Count; i++)
            {
                t_JoueurNd[i, 0] = listBox_NdO.Items[i].ToString();
            }

            for (int i = 0; i < listBox_NdF.Items.Count; i++)
            {
                t_JoueurNd[i, 1] = listBox_NdF.Items[i].ToString();
            }
        }

        bool CompareRecursiveTree(TreeNode tn1, TreeNode tn2, bool validExoTree)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
                validExoTree = false;
            }
            int compare = Math.Min(tn1.Nodes.Count, tn2.Nodes.Count);
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                validExoTree = CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i], validExoTree );
            }
            return validExoTree; 
        }

        bool CompareTreeNodes(TreeView tv1, TreeView tv2, bool validExoTree )
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                validExoTree = CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i], validExoTree);
            }
            return validExoTree;
        }

        private void btnValiderNd_Click(object sender, EventArgs e)
        {
            //Correction noeud
            bool validExoNd = true;

            if (listBox_NdO.Items.Count == g.L_Etats.Length)
            {
                 //Véfification Noeud Ouvert 
                 for (int i = 0; i < listBox_NdO.Items.Count; i++)
                 {
                     if (t_JoueurNd[i, 0] == ";")
                     { }
                     else
                     {
                         if (t_JoueurNd[i, 0] != g.L_Etats[i, 0].ToString())
                         {
                             validExoNd = false;
                         }

                     }
                 }

                 //Véfification Noeud Fermé 
                 for (int i = 0; i < listBox_NdF.Items.Count; i++)
                 {
                     if (t_JoueurNd[i, 1] == ";")
                     { }
                     else
                     {
                         if (t_JoueurNd[i, 1] != g.L_Etats[i, 1].ToString())
                         {
                             validExoNd = false;
                         }
                     }
                 }

            }
             else
                 validExoNd = false;

            bool b = validExoNd;
        }

        private void btnValiderTree_Click(object sender, EventArgs e)
        {
            //Correction Arbre 
            bool validExoTree = true;
            validExoTree = CompareTreeNodes(this.treeView1, this.treeView2, validExoTree);
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            Form dijCorrect = new DijkstraCorrect(img, numinitial, numfinal); 
            dijCorrect.ShowDialog();
            
        }
   }
}
