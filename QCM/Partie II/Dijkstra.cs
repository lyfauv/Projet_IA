using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QCM.Partie_II
{
    public partial class Dijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes;
        static public string img;
        static public int numinitial;
        static public int numfinal;
        public Dijkstra()
        {
            InitializeComponent();
        }

        private void button_txt_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(1, 2);
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
            labelNdInit.Text = (r.Next(1, nbnodes).ToString());
            // Affichage aléatoire du noeud final
            labelNdFinal.Text = (r.Next(1, nbnodes).ToString());

            // 2ème ligne : image associée
            ligne = monStreamReader.ReadLine();
            i = 0;
            while (ligne[i] != ':') i++;
            string img = "../../";
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

            //pictureBox1.Size = Image.FromFile(img).Size;
            pictureBox1.Image = Image.FromFile(img);

            for (int m=1 ; m < nbnodes+1; m++)
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
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {

            // On transfère les items sélectionnés à la liste
            string sNdO = "";
            for (int m=0; m < checkedListBox_NdO.CheckedItems.Count; m++)
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

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(labelNdInit.Text);
            numfinal = Convert.ToInt32(labelNdFinal.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBoxgraphe2.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeView1);
        }
    }
}
