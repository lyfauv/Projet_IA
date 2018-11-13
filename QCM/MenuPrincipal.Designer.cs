namespace QCM
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titre = new System.Windows.Forms.Label();
            this.QCM = new System.Windows.Forms.Button();
            this.Dijkstra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Titre.Location = new System.Drawing.Point(70, 50);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(596, 29);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Testez vos connaissances sur l\'intelligence Artificielle !";
            // 
            // QCM
            // 
            this.QCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QCM.Location = new System.Drawing.Point(230, 198);
            this.QCM.Name = "QCM";
            this.QCM.Size = new System.Drawing.Size(292, 44);
            this.QCM.TabIndex = 1;
            this.QCM.Text = "Tester mes connaissances sur l\'IA";
            this.QCM.UseVisualStyleBackColor = true;
            this.QCM.Click += new System.EventHandler(this.QCM_Click);
            // 
            // Dijkstra
            // 
            this.Dijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Dijkstra.Location = new System.Drawing.Point(230, 291);
            this.Dijkstra.Name = "Dijkstra";
            this.Dijkstra.Size = new System.Drawing.Size(292, 44);
            this.Dijkstra.TabIndex = 2;
            this.Dijkstra.Text = "Tester mes connaissances sur l\'algorithme de Dijkstra";
            this.Dijkstra.UseVisualStyleBackColor = true;
            this.Dijkstra.Click += new System.EventHandler(this.Dijkstra_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 567);
            this.Controls.Add(this.Dijkstra);
            this.Controls.Add(this.QCM);
            this.Controls.Add(this.Titre);
            this.Name = "MenuPrincipal";
            this.Text = "L\'IA c\'est fun !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Button QCM;
        private System.Windows.Forms.Button Dijkstra;
    }
}

