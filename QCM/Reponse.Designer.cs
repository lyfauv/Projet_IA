namespace QCM
{
    partial class Reponse
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
            this.LabelSolution = new System.Windows.Forms.Label();
            this.LBonneRep = new System.Windows.Forms.Label();
            this.BonneRep = new System.Windows.Forms.Label();
            this.Explication = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.JusteOuFaux = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSolution
            // 
            this.LabelSolution.AutoSize = true;
            this.LabelSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelSolution.Location = new System.Drawing.Point(288, 82);
            this.LabelSolution.Name = "LabelSolution";
            this.LabelSolution.Size = new System.Drawing.Size(67, 20);
            this.LabelSolution.TabIndex = 5;
            this.LabelSolution.Text = "Solution";
            this.LabelSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSolution.UseMnemonic = false;
            // 
            // LBonneRep
            // 
            this.LBonneRep.AutoSize = true;
            this.LBonneRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBonneRep.Location = new System.Drawing.Point(63, 212);
            this.LBonneRep.Name = "LBonneRep";
            this.LBonneRep.Size = new System.Drawing.Size(167, 17);
            this.LBonneRep.TabIndex = 6;
            this.LBonneRep.Text = "La bonne réponse était : ";
            this.LBonneRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBonneRep.UseMnemonic = false;
            // 
            // BonneRep
            // 
            this.BonneRep.AutoSize = true;
            this.BonneRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BonneRep.Location = new System.Drawing.Point(289, 212);
            this.BonneRep.Name = "BonneRep";
            this.BonneRep.Size = new System.Drawing.Size(43, 17);
            this.BonneRep.TabIndex = 7;
            this.BonneRep.Text = "Label";
            this.BonneRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BonneRep.UseMnemonic = false;
            // 
            // Explication
            // 
            this.Explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Explication.Location = new System.Drawing.Point(63, 255);
            this.Explication.Name = "Explication";
            this.Explication.Size = new System.Drawing.Size(523, 221);
            this.Explication.TabIndex = 8;
            this.Explication.Text = "Label";
            this.Explication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Explication.UseMnemonic = false;
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ok.Location = new System.Drawing.Point(259, 479);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(130, 37);
            this.Ok.TabIndex = 9;
            this.Ok.Text = "J\'ai compris !";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // JusteOuFaux
            // 
            this.JusteOuFaux.AutoSize = true;
            this.JusteOuFaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JusteOuFaux.Location = new System.Drawing.Point(63, 159);
            this.JusteOuFaux.Name = "JusteOuFaux";
            this.JusteOuFaux.Size = new System.Drawing.Size(43, 17);
            this.JusteOuFaux.TabIndex = 10;
            this.JusteOuFaux.Text = "Label";
            this.JusteOuFaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JusteOuFaux.UseMnemonic = false;
            // 
            // Reponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 540);
            this.Controls.Add(this.JusteOuFaux);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Explication);
            this.Controls.Add(this.BonneRep);
            this.Controls.Add(this.LBonneRep);
            this.Controls.Add(this.LabelSolution);
            this.Name = "Reponse";
            this.Text = "Reponse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSolution;
        private System.Windows.Forms.Label LBonneRep;
        private System.Windows.Forms.Label BonneRep;
        private System.Windows.Forms.Label Explication;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label JusteOuFaux;
    }
}