using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class Reponse : Form
    {
        lecteurXML lecteur;
        string explication;
        int solution;
        int numQuestion;
        string fichier;
        int reponse;

        public Reponse()
        {
            InitializeComponent();
            lecteur = new lecteurXML();
        }

        public Reponse(int NumQuestion, string Fichier, int Reponse):this()
        {
            // On récupère l'explication de la bonne réponse
            explication = lecteur.retournerExplication(numQuestion, fichier);

            numQuestion = NumQuestion;
            fichier = Fichier;
            reponse = Reponse;

            // On récupère l'indice de la bonne réponse
            int reponseJuste = lecteur.retournerReponseJusteInt(numQuestion, fichier);


            // On affiche si oui ou non l'élève a coché la bonne réponse
            if (reponseJuste == reponse)
                JusteOuFaux.Text = "Vous avez donné la bonne réponse !";
            else
                JusteOuFaux.Text = "Vous avez donné la mauvaise réponse :s";

            // On affiche l'intitulé de la bonne réponse et son explication
            Explication.Text = explication;
            BonneRep.Text = lecteur.retournerReponseJusteString(numQuestion, fichier);

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
