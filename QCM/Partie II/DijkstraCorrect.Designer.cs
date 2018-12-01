namespace QCM.Partie_II
{
    partial class DijkstraCorrect
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
            this.label3 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox_NdO = new System.Windows.Forms.ListBox();
            this.labellistbox = new System.Windows.Forms.Label();
            this.listBox_NdF = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNdFinal = new System.Windows.Forms.Label();
            this.labelNdInit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Qt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Correction Dijkstra";
            // 
            // treeView
            // 
            this.treeView.FullRowSelect = true;
            this.treeView.Location = new System.Drawing.Point(391, 363);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(147, 147);
            this.treeView.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(100, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // listBox_NdO
            // 
            this.listBox_NdO.FormattingEnabled = true;
            this.listBox_NdO.Location = new System.Drawing.Point(100, 363);
            this.listBox_NdO.Name = "listBox_NdO";
            this.listBox_NdO.Size = new System.Drawing.Size(100, 147);
            this.listBox_NdO.TabIndex = 58;
            // 
            // labellistbox
            // 
            this.labellistbox.AutoSize = true;
            this.labellistbox.Location = new System.Drawing.Point(97, 347);
            this.labellistbox.Name = "labellistbox";
            this.labellistbox.Size = new System.Drawing.Size(72, 13);
            this.labellistbox.TabIndex = 59;
            this.labellistbox.Text = "Noeud ouvert";
            // 
            // listBox_NdF
            // 
            this.listBox_NdF.FormattingEnabled = true;
            this.listBox_NdF.Location = new System.Drawing.Point(218, 363);
            this.listBox_NdF.Name = "listBox_NdF";
            this.listBox_NdF.Size = new System.Drawing.Size(100, 147);
            this.listBox_NdF.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Noeud fermé";
            // 
            // labelNdFinal
            // 
            this.labelNdFinal.AutoSize = true;
            this.labelNdFinal.Location = new System.Drawing.Point(430, 88);
            this.labelNdFinal.Name = "labelNdFinal";
            this.labelNdFinal.Size = new System.Drawing.Size(13, 13);
            this.labelNdFinal.TabIndex = 65;
            this.labelNdFinal.Text = "0";
            // 
            // labelNdInit
            // 
            this.labelNdInit.AutoSize = true;
            this.labelNdInit.Location = new System.Drawing.Point(280, 88);
            this.labelNdInit.Name = "labelNdInit";
            this.labelNdInit.Size = new System.Drawing.Size(13, 13);
            this.labelNdInit.TabIndex = 64;
            this.labelNdInit.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Noeud final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Noeud initial :";
            // 
            // btn_Qt
            // 
            this.btn_Qt.Location = new System.Drawing.Point(252, 558);
            this.btn_Qt.Name = "btn_Qt";
            this.btn_Qt.Size = new System.Drawing.Size(133, 34);
            this.btn_Qt.TabIndex = 66;
            this.btn_Qt.Text = "Quitter ";
            this.btn_Qt.UseVisualStyleBackColor = true;
            this.btn_Qt.Click += new System.EventHandler(this.btn_Qt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Arbre";
            // 
            // DijkstraCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Qt);
            this.Controls.Add(this.labelNdFinal);
            this.Controls.Add(this.labelNdInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_NdO);
            this.Controls.Add(this.labellistbox);
            this.Controls.Add(this.listBox_NdF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label3);
            this.Name = "DijkstraCorrect";
            this.Text = "DijkstraCorrect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_NdO;
        private System.Windows.Forms.Label labellistbox;
        private System.Windows.Forms.ListBox listBox_NdF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNdFinal;
        private System.Windows.Forms.Label labelNdInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Qt;
        private System.Windows.Forms.Label label5;
    }
}