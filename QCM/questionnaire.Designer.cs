namespace QCM
{
    partial class questionnaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumQuestion = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Reponses = new System.Windows.Forms.CheckedListBox();
            this.Fin = new System.Windows.Forms.Label();
            this.Suivant = new System.Windows.Forms.Button();
            this.Explications = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumQuestion
            // 
            this.NumQuestion.AutoSize = true;
            this.NumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumQuestion.Location = new System.Drawing.Point(39, 28);
            this.NumQuestion.Name = "NumQuestion";
            this.NumQuestion.Size = new System.Drawing.Size(145, 31);
            this.NumQuestion.TabIndex = 0;
            this.NumQuestion.Text = "Question 0";
            this.NumQuestion.Visible = false;
            this.NumQuestion.Click += new System.EventHandler(this.NumQuestion_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Question.Location = new System.Drawing.Point(42, 93);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(92, 20);
            this.Question.TabIndex = 1;
            this.Question.Text = "La question";
            this.Question.Visible = false;
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Valider.Location = new System.Drawing.Point(500, 410);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(131, 32);
            this.Valider.TabIndex = 3;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Visible = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Reponses
            // 
            this.Reponses.BackColor = System.Drawing.SystemColors.Menu;
            this.Reponses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reponses.FormattingEnabled = true;
            this.Reponses.Items.AddRange(new object[] {
            "Rep1",
            "Rep2",
            "Rep3",
            "Rep4"});
            this.Reponses.Location = new System.Drawing.Point(46, 158);
            this.Reponses.Margin = new System.Windows.Forms.Padding(5);
            this.Reponses.Name = "Reponses";
            this.Reponses.Size = new System.Drawing.Size(586, 195);
            this.Reponses.TabIndex = 2;
            this.Reponses.Visible = false;
            // 
            // Fin
            // 
            this.Fin.AutoSize = true;
            this.Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fin.Location = new System.Drawing.Point(325, 93);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(48, 20);
            this.Fin.TabIndex = 4;
            this.Fin.Text = "Label";
            this.Fin.UseMnemonic = false;
            this.Fin.Visible = false;
            this.Fin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Suivant
            // 
            this.Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Suivant.Location = new System.Drawing.Point(260, 463);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(180, 32);
            this.Suivant.TabIndex = 5;
            this.Suivant.Text = "Commencer le Test";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Explications
            // 
            this.Explications.AutoSize = true;
            this.Explications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Explications.Location = new System.Drawing.Point(43, 158);
            this.Explications.Name = "Explications";
            this.Explications.Size = new System.Drawing.Size(43, 17);
            this.Explications.TabIndex = 6;
            this.Explications.Text = "Label";
            this.Explications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Explications.UseMnemonic = false;
            // 
            // questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 553);
            this.Controls.Add(this.Explications);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Reponses);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.NumQuestion);
            this.Name = "questionnaire";
            this.Text = "questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumQuestion;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.CheckedListBox Reponses;
        private System.Windows.Forms.Label Fin;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Label Explications;
    }
}