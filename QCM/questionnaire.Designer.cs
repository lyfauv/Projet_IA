﻿namespace QCM
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
            this.Fin = new System.Windows.Forms.Label();
            this.Suivant = new System.Windows.Forms.Button();
            this.Rep1 = new System.Windows.Forms.RadioButton();
            this.Rep2 = new System.Windows.Forms.RadioButton();
            this.Rep3 = new System.Windows.Forms.RadioButton();
            this.Rep4 = new System.Windows.Forms.RadioButton();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Explications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // NumQuestion
            // 
            this.NumQuestion.AutoSize = true;
            this.NumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumQuestion.Location = new System.Drawing.Point(52, 34);
            this.NumQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumQuestion.Name = "NumQuestion";
            this.NumQuestion.Size = new System.Drawing.Size(181, 39);
            this.NumQuestion.TabIndex = 0;
            this.NumQuestion.Text = "Question 0";
            this.NumQuestion.Visible = false;
            this.NumQuestion.Click += new System.EventHandler(this.NumQuestion_Click);
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Question.Location = new System.Drawing.Point(56, 114);
            this.Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(384, 115);
            this.Question.TabIndex = 1;
            this.Question.Text = "La question";
            this.Question.Visible = false;
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Valider.Location = new System.Drawing.Point(667, 505);
            this.Valider.Margin = new System.Windows.Forms.Padding(4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(175, 39);
            this.Valider.TabIndex = 3;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Visible = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Fin
            // 
            this.Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fin.Location = new System.Drawing.Point(272, 102);
            this.Fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(427, 226);
            this.Fin.TabIndex = 4;
            this.Fin.Text = "Label";
            this.Fin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fin.UseMnemonic = false;
            this.Fin.Visible = false;
            this.Fin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Suivant
            // 
            this.Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Suivant.Location = new System.Drawing.Point(347, 570);
            this.Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(240, 39);
            this.Suivant.TabIndex = 5;
            this.Suivant.Text = "Commencer le Test";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Rep1
            // 
            this.Rep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rep1.Location = new System.Drawing.Point(61, 221);
            this.Rep1.Margin = new System.Windows.Forms.Padding(4);
            this.Rep1.Name = "Rep1";
            this.Rep1.Size = new System.Drawing.Size(799, 69);
            this.Rep1.TabIndex = 7;
            this.Rep1.TabStop = true;
            this.Rep1.Text = "Rep1";
            this.Rep1.UseVisualStyleBackColor = true;
            this.Rep1.Visible = false;
            // 
            // Rep2
            // 
            this.Rep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rep2.Location = new System.Drawing.Point(59, 289);
            this.Rep2.Margin = new System.Windows.Forms.Padding(4);
            this.Rep2.Name = "Rep2";
            this.Rep2.Size = new System.Drawing.Size(799, 69);
            this.Rep2.TabIndex = 8;
            this.Rep2.TabStop = true;
            this.Rep2.Text = "Rep2";
            this.Rep2.UseVisualStyleBackColor = true;
            this.Rep2.Visible = false;
            // 
            // Rep3
            // 
            this.Rep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rep3.Location = new System.Drawing.Point(60, 360);
            this.Rep3.Margin = new System.Windows.Forms.Padding(4);
            this.Rep3.Name = "Rep3";
            this.Rep3.Size = new System.Drawing.Size(799, 69);
            this.Rep3.TabIndex = 9;
            this.Rep3.TabStop = true;
            this.Rep3.Text = "Rep3";
            this.Rep3.UseVisualStyleBackColor = true;
            this.Rep3.Visible = false;
            // 
            // Rep4
            // 
            this.Rep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rep4.Location = new System.Drawing.Point(60, 434);
            this.Rep4.Margin = new System.Windows.Forms.Padding(4);
            this.Rep4.Name = "Rep4";
            this.Rep4.Size = new System.Drawing.Size(799, 69);
            this.Rep4.TabIndex = 10;
            this.Rep4.TabStop = true;
            this.Rep4.Text = "Rep4";
            this.Rep4.UseVisualStyleBackColor = true;
            this.Rep4.Visible = false;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(447, 1);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(449, 228);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 11;
            this.Image.TabStop = false;
            this.Image.Visible = false;
            // 
            // Explications
            // 
            this.Explications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Explications.Location = new System.Drawing.Point(73, 171);
            this.Explications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Explications.Name = "Explications";
            this.Explications.Size = new System.Drawing.Size(785, 305);
            this.Explications.TabIndex = 6;
            this.Explications.Text = "Label";
            this.Explications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Explications.UseMnemonic = false;
            // 
            // questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 681);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Rep4);
            this.Controls.Add(this.Rep3);
            this.Controls.Add(this.Rep2);
            this.Controls.Add(this.Explications);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.NumQuestion);
            this.Controls.Add(this.Rep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "questionnaire";
            this.Text = "questionnaire";
            this.Load += new System.EventHandler(this.questionnaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumQuestion;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label Fin;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.RadioButton Rep1;
        private System.Windows.Forms.RadioButton Rep2;
        private System.Windows.Forms.RadioButton Rep3;
        private System.Windows.Forms.RadioButton Rep4;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label Explications;
    }
}