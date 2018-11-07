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
    public partial class questionnaire : Form
    {
        int numQuestion;
        lecteurXML lecteur;
        Random r = new Random();
        string fichier;

        /// <summary>
        /// Initialisation du questionnaire
        /// </summary>
        public questionnaire()
        {
            InitializeComponent();
            lecteur = new lecteurXML();
            fichier = "questions_reponses.xml";

            //Affichage première question
            numQuestion = 1;
            NumQuestion.Text = "Question " + numQuestion + " sur 20";
            int numQuestionDonne = r.Next(1, 2);
            Question.Text = lecteur.retournerQuestion(numQuestionDonne, fichier);

            // Affichage des réponses de la première question
            AfficheReponses(numQuestionDonne);


        }

        /// <summary>
        /// Affiche les réponses pour une question donnée
        /// </summary>
        /// <param name="numQuestion"></param>
        public void AfficheReponses(int numQuestion)
        {

            for (int i = 0; i < 4; i++)
            {
                Reponses.Items[i] = lecteur.retournerReponse(numQuestion, i + 1 , fichier);
            }

        }


        private void NumQuestion_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Validation de la réponse et passage à la réponse suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            numQuestion++;

        }
    }
}
