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
        List<string> questions;
        Random r = new Random();

        public questionnaire()
        {
            InitializeComponent();

            //Affichage première question
            numQuestion = 1;
            NumQuestion.Text = "Question " + numQuestion + " sur 20";
            Question.Text = questions[r.Next(0, questions.Count)];


        }

        private void NumQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
