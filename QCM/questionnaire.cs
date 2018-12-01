using QCM.Partie_II;
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
        int reponse;
        List<int> questionPassees;
        static bool arbreJuste = false;
        static bool noeudJuste = false;

        /// <summary>
        /// Initialisation du questionnaire
        /// </summary>
        public questionnaire()
        {
            InitializeComponent();

            // Petit texte d'introduction au QCM
            string texte = "Bienvenue sur IAQuest ! \nVous allez devoir répondre à une série de 20 questions. \n";
            texte += "Pour chaque question, une seule réponse est correcte. \nVous devez cocher la bonne réponse parmi les 4 réponses données. \n";
            texte += "La note associée à chaque question est donnée à côté de celle-ci. \nChaque bonne réponse vous donne la totalité de la note associée à la question. \n";
            texte += "Votre note finale est une note sur 20. \n";
            texte += "Pour valider votre réponse, cliquez sur le bouton 'Valider'. \nAttention ! Une fois validée, vous ne pouvez plus modifier votre réponse. \n";
            texte += "Après avoir validé votre réponse, la réponse à la question et son explication vous sera donnée ainsi que les points que vous avez obtenus. \n";
            texte += "Pour commencer le test, appuyer sur le bouton 'Commencer le test'. \n";
            texte += "Bon courage ! :-)";
            Explications.Text = texte;

            questionPassees = new List<int>();
        }

        /// <summary>
        /// Affiche les réponses pour une question donnée
        /// </summary>
        /// <param name="numQuestion"></param>
        public void AfficheReponses(int numQuestion)
        {
            // On modifie le texte de chaque bouton radio avec le contenu du fichier XML
            Rep1.Text = lecteur.retournerReponse(numQuestion, 1, fichier);
            Rep2.Text = lecteur.retournerReponse(numQuestion, 2, fichier);
            Rep3.Text = lecteur.retournerReponse(numQuestion, 3, fichier);
            Rep4.Text = lecteur.retournerReponse(numQuestion, 4, fichier);
        }

        /// <summary>
        /// On commence le test après avoir cliqué sur le bouton commencer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Suivant_Click(object sender, EventArgs e)
        {
            // On affiche les intitulés des questions et les réponses associées
            Explications.Visible = false;
            Suivant.Visible = false;
            Valider.Visible = true;
            NumQuestion.Visible = true;
            Question.Visible = true;
            Rep1.Visible = true;
            Rep2.Visible = true;
            Rep3.Visible = true;
            Rep4.Visible = true;

            // Initialisation des variables
            lecteur = new lecteurXML();
            fichier = "../../questions_reponses.xml";

            // Affichage première question
            numQuestion = 1;
            NumQuestion.Text = "Question " + numQuestion + " sur 20";

            // On tire au hasard le numéro de la question que l'on va afficher
            numQuestionDonne = r.Next(1, 21);
            Question.Text = lecteur.retournerQuestion(numQuestionDonne, fichier);
            questionPassees.Add(numQuestionDonne);

            // Affichage des réponses de la première question
            AfficheReponses(numQuestionDonne);

            if (lecteur.ImageExiste(numQuestionDonne, fichier))
            {
                Image.Visible = true;
                Image.ImageLocation = lecteur.retournerImage(numQuestionDonne, fichier);
            }
        }

        /// <summary>
        /// Affiche la bonne réponse avec une explication après que l'on ai cliqué sur suivants
        /// </summary>
        public void AfficheSolution()
        {
            string msgReponse;
            string explication;
            string repExplication;

            // On récupère l'explication de la bonne réponse
            explication = lecteur.retournerExplication(numQuestionDonne, fichier);

            // On récupère l'indice de la bonne réponse
            int reponseJuste = lecteur.retournerReponseJusteInt(numQuestionDonne, fichier);


            // On affiche si oui ou non l'élève a coché la bonne réponse
            if (reponseJuste == reponse)
                msgReponse = "Vous avez donné la bonne réponse !";
            else
                msgReponse = "Vous avez donné la mauvaise réponse :s";

            repExplication = msgReponse + "\nLa bonne réponse était : " + lecteur.retournerReponseJusteString(numQuestionDonne, fichier) + "\n" + explication;

            var result = MessageBox.Show(repExplication, "Solution", MessageBoxButtons.OK);
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
                if (Rep1.Checked || Rep2.Checked || Rep3.Checked || Rep4.Checked)
                {
                    // On regarde quelle réponse à été cochée

                    if (Rep1.Checked)
                        reponse = 1;
                    if (Rep2.Checked)
                        reponse = 2;
                    if (Rep3.Checked)
                        reponse = 3;
                    if (Rep4.Checked)
                        reponse = 4;

                    // On augmente la note si la réponse cochée est la bonne
                    if (lecteur.retournerReponseJusteInt(numQuestionDonne, fichier) == reponse)
                        score += lecteur.retournerScore(numQuestionDonne, fichier);

                }

                AfficheSolution();

                // On décoche les boutons radios
                Rep1.Checked = false;
                Rep2.Checked = false;
                Rep3.Checked = false;
                Rep4.Checked = false;

                // On passe à la question suivante
                numQuestionDonne = r.Next(1, 21);
                NumQuestion.Text = "Question " + Convert.ToString(numQuestion) + " sur 20";

                // On regarde si la question n'a pas déjà été donnée
                bool present = true;
                while (present)
                {
                    present = false;
                    foreach (int element in questionPassees)
                    {
                        if (element == numQuestionDonne)
                        {
                            present = true;
                            numQuestionDonne = r.Next(1, 21);
                        }

                    }
                }
                if (numQuestion == 20) // Question Dijkstra
                {
                    
                    Dijkstra formulaire = new Dijkstra();
                    formulaire.ShowDialog();
                    arbreJuste = formulaire.validExoTree;
                    noeudJuste = formulaire.validExoNd;

                    if (arbreJuste)
                        score += 1;

                    if (noeudJuste)
                        score += 2;

                    // On cache tous ce qui est en rapport avec les questions et on fait apparaître le label de fin du QCM
                    Fin.Visible = true;
                    Valider.Visible = false;
                    NumQuestion.Visible = false;
                    Question.Visible = false;
                    Rep1.Visible = false;
                    Rep2.Visible = false;
                    Rep3.Visible = false;
                    Rep4.Visible = false;
                    Image.Visible = false;

                    string reussite = "mince";

                    // On cherche le score total des questions
                    int scoreTotal = 0;
                    foreach (int element in questionPassees)
                    {
                        scoreTotal += lecteur.retournerScore(element, fichier);
                    }

                    scoreTotal += 3; // Correspond au score de la question Dijkstra

                    if (((score * 20) / scoreTotal) >= 10)
                        reussite = "Vous avez réussi votre examen ! :-)";
                    else
                        reussite = "Il vous manque encore quelques connaissances sur le sujet :s";

                    // On convertit la note sur 20 et on affiche la note obtenue
                    Fin.Text = "Vous avez terminé ! Vous avez obtenu une note de " + ((score * 20) / scoreTotal) + " / 20 ! \n" + reussite;
                }
                else
                {
                    // On ajoute le numéro de la question obtenue à la liste des questions déjà données
                    questionPassees.Add(numQuestionDonne);

                    Question.Text = lecteur.retournerQuestion(numQuestionDonne, fichier);

                    if (lecteur.ImageExiste(numQuestionDonne, fichier))
                    {
                        Image.Visible = true;
                        Image.ImageLocation = lecteur.retournerImage(numQuestionDonne, fichier);
                    }

                    // Affichage des réponses de la question suivante
                    AfficheReponses(numQuestionDonne);
                }
            }
            else
            {
                
            }
        }
    }
}