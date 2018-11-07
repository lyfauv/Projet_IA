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
        int score = 0;
        int numQuestion;
        lecteurXML lecteur;
        Random r = new Random();
        string fichier;
        int numQuestionDonne;

        /// <summary>
        /// Initialisation du questionnaire
        /// </summary>
        public questionnaire()
        {
            InitializeComponent();

            // Initialisation des variables
            lecteur = new lecteurXML();
            fichier = "questions_reponses.xml";

            // Affichage première question
            numQuestion = 1;
            NumQuestion.Text = "Question " + numQuestion + " sur 20";

            // On tire au hasard le numéro de la question que l'on va afficher
            numQuestionDonne = r.Next(1, 2);
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

            if (numQuestion <= 20)
            {
                // On regarde si la réponse cochée est la bonne
                if (Reponses.CheckedItems.Count <= 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (Reponses.GetItemChecked(i))
                        {
                            // Si le numéro de la réponse cochée est la bonne, on augmente la note de 1
                            if (lecteur.retournerReponseJusteInt(numQuestionDonne, fichier) == i + 1)
                                score += 1;
                        }
                    }
                }

                // On modifie le score en conséquence

                // On passe à la question suivante
                numQuestionDonne = r.Next(1, 2);
                Question.Text = lecteur.retournerQuestion(numQuestionDonne, fichier);

                // Affichage des réponses de la question suivante
                AfficheReponses(numQuestionDonne);
            }
            else
            {
                // On cache tous ce qui est en rapport avec les questions et on fait apparaître le label de fin du QCM
                Fin.Visible = true;
                Valider.Visible = false;
                NumQuestion.Visible = false;
                Question.Visible = false;
                Reponses.Visible = false;

                string reussite;

                if (score >= 10)
                    reussite = "Vous avez réussi votre examen ! :-)";
                else
                    reussite = "Il vous manque encore quelques connaissances sur le sujet :s";
                Fin.Text = "Vous avez terminé ! \n Vous avez obtenu une note de " + score + " / 20 ! \n" + reussite;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
