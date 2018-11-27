namespace QCM.Partie_II
{
    partial class Dijkstra
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
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.button_txt = new System.Windows.Forms.Button();
            this.listBox_NdO = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labellistbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_NdF = new System.Windows.Forms.ListBox();
            this.buttonValid = new System.Windows.Forms.Button();
            this.labeltxtNdF = new System.Windows.Forms.Label();
            this.labeltxtNdO = new System.Windows.Forms.Label();
            this.labelNdInit = new System.Windows.Forms.Label();
            this.labelNdFinal = new System.Windows.Forms.Label();
            this.checkedListBox_NdO = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_NdF = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(559, 76);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 186);
            this.listBoxgraphe.TabIndex = 19;
            // 
            // button_txt
            // 
            this.button_txt.Location = new System.Drawing.Point(12, 21);
            this.button_txt.Name = "button_txt";
            this.button_txt.Size = new System.Drawing.Size(68, 23);
            this.button_txt.TabIndex = 18;
            this.button_txt.Text = "Init";
            this.button_txt.UseVisualStyleBackColor = true;
            this.button_txt.Click += new System.EventHandler(this.button_txt_Click_1);
            // 
            // listBox_NdO
            // 
            this.listBox_NdO.FormattingEnabled = true;
            this.listBox_NdO.Location = new System.Drawing.Point(383, 332);
            this.listBox_NdO.Name = "listBox_NdO";
            this.listBox_NdO.Size = new System.Drawing.Size(100, 121);
            this.listBox_NdO.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noeud final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Noeud initial :";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(103, 21);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 23);
            this.buttonA.TabIndex = 13;
            this.buttonA.Text = "A*";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(42, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 186);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labellistbox
            // 
            this.labellistbox.AutoSize = true;
            this.labellistbox.Location = new System.Drawing.Point(380, 307);
            this.labellistbox.Name = "labellistbox";
            this.labellistbox.Size = new System.Drawing.Size(72, 13);
            this.labellistbox.TabIndex = 21;
            this.labellistbox.Text = "Noeud ouvert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Noeud fermé";
            // 
            // listBox_NdF
            // 
            this.listBox_NdF.FormattingEnabled = true;
            this.listBox_NdF.Location = new System.Drawing.Point(510, 332);
            this.listBox_NdF.Name = "listBox_NdF";
            this.listBox_NdF.Size = new System.Drawing.Size(100, 121);
            this.listBox_NdF.TabIndex = 25;
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(103, 501);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(98, 31);
            this.buttonValid.TabIndex = 26;
            this.buttonValid.Text = "Valider";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // labeltxtNdF
            // 
            this.labeltxtNdF.AutoSize = true;
            this.labeltxtNdF.Location = new System.Drawing.Point(180, 291);
            this.labeltxtNdF.Name = "labeltxtNdF";
            this.labeltxtNdF.Size = new System.Drawing.Size(68, 13);
            this.labeltxtNdF.TabIndex = 31;
            this.labeltxtNdF.Text = "Noeud fermé";
            // 
            // labeltxtNdO
            // 
            this.labeltxtNdO.AutoSize = true;
            this.labeltxtNdO.Location = new System.Drawing.Point(49, 291);
            this.labeltxtNdO.Name = "labeltxtNdO";
            this.labeltxtNdO.Size = new System.Drawing.Size(72, 13);
            this.labeltxtNdO.TabIndex = 30;
            this.labeltxtNdO.Text = "Noeud ouvert";
            // 
            // labelNdInit
            // 
            this.labelNdInit.AutoSize = true;
            this.labelNdInit.Location = new System.Drawing.Point(741, 77);
            this.labelNdInit.Name = "labelNdInit";
            this.labelNdInit.Size = new System.Drawing.Size(13, 13);
            this.labelNdInit.TabIndex = 32;
            this.labelNdInit.Text = "0";
            // 
            // labelNdFinal
            // 
            this.labelNdFinal.AutoSize = true;
            this.labelNdFinal.Location = new System.Drawing.Point(737, 99);
            this.labelNdFinal.Name = "labelNdFinal";
            this.labelNdFinal.Size = new System.Drawing.Size(13, 13);
            this.labelNdFinal.TabIndex = 33;
            this.labelNdFinal.Text = "0";
            // 
            // checkedListBox_NdO
            // 
            this.checkedListBox_NdO.FormattingEnabled = true;
            this.checkedListBox_NdO.Location = new System.Drawing.Point(41, 307);
            this.checkedListBox_NdO.Name = "checkedListBox_NdO";
            this.checkedListBox_NdO.Size = new System.Drawing.Size(89, 169);
            this.checkedListBox_NdO.TabIndex = 50;
            // 
            // checkedListBox_NdF
            // 
            this.checkedListBox_NdF.FormattingEnabled = true;
            this.checkedListBox_NdF.Location = new System.Drawing.Point(172, 307);
            this.checkedListBox_NdF.Name = "checkedListBox_NdF";
            this.checkedListBox_NdF.Size = new System.Drawing.Size(89, 169);
            this.checkedListBox_NdF.TabIndex = 51;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 631);
            this.Controls.Add(this.checkedListBox_NdF);
            this.Controls.Add(this.checkedListBox_NdO);
            this.Controls.Add(this.labelNdFinal);
            this.Controls.Add(this.labelNdInit);
            this.Controls.Add(this.labeltxtNdF);
            this.Controls.Add(this.labeltxtNdO);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.listBox_NdF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labellistbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.button_txt);
            this.Controls.Add(this.listBox_NdO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonA);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.Button button_txt;
        private System.Windows.Forms.ListBox listBox_NdO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labellistbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_NdF;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Label labeltxtNdF;
        private System.Windows.Forms.Label labeltxtNdO;
        private System.Windows.Forms.Label labelNdInit;
        private System.Windows.Forms.Label labelNdFinal;
        private System.Windows.Forms.CheckedListBox checkedListBox_NdO;
        private System.Windows.Forms.CheckedListBox checkedListBox_NdF;
    }
}