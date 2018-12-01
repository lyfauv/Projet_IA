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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dijkstra));
            this.listBoxgraphe1 = new System.Windows.Forms.ListBox();
            this.button_Init = new System.Windows.Forms.Button();
            this.listBox_NdO = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labellistbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_NdF = new System.Windows.Forms.ListBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.labeltxtNdF = new System.Windows.Forms.Label();
            this.labeltxtNdO = new System.Windows.Forms.Label();
            this.labelNdInit = new System.Windows.Forms.Label();
            this.labelNdFinal = new System.Windows.Forms.Label();
            this.checkedListBox_NdO = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_NdF = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValiderNd = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValiderTree = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.buttonTerminer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxgraphe1
            // 
            this.listBoxgraphe1.FormattingEnabled = true;
            this.listBoxgraphe1.Location = new System.Drawing.Point(529, 143);
            this.listBoxgraphe1.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe1.Name = "listBoxgraphe1";
            this.listBoxgraphe1.Size = new System.Drawing.Size(100, 186);
            this.listBoxgraphe1.TabIndex = 19;
            // 
            // button_Init
            // 
            this.button_Init.Location = new System.Drawing.Point(12, 108);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(68, 23);
            this.button_Init.TabIndex = 18;
            this.button_Init.Text = "Init";
            this.button_Init.UseVisualStyleBackColor = true;
            this.button_Init.Click += new System.EventHandler(this.button_Init_Click);
            // 
            // listBox_NdO
            // 
            this.listBox_NdO.FormattingEnabled = true;
            this.listBox_NdO.Location = new System.Drawing.Point(230, 63);
            this.listBox_NdO.Name = "listBox_NdO";
            this.listBox_NdO.Size = new System.Drawing.Size(100, 121);
            this.listBox_NdO.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noeud final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Noeud initial :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labellistbox
            // 
            this.labellistbox.AutoSize = true;
            this.labellistbox.Location = new System.Drawing.Point(227, 47);
            this.labellistbox.Name = "labellistbox";
            this.labellistbox.Size = new System.Drawing.Size(72, 13);
            this.labellistbox.TabIndex = 21;
            this.labellistbox.Text = "Noeud ouvert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Noeud fermé";
            // 
            // listBox_NdF
            // 
            this.listBox_NdF.FormattingEnabled = true;
            this.listBox_NdF.Location = new System.Drawing.Point(336, 63);
            this.listBox_NdF.Name = "listBox_NdF";
            this.listBox_NdF.Size = new System.Drawing.Size(100, 121);
            this.listBox_NdF.TabIndex = 25;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(61, 203);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(98, 31);
            this.btnEnvoyer.TabIndex = 26;
            this.btnEnvoyer.Text = "Envoyer ";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // labeltxtNdF
            // 
            this.labeltxtNdF.AutoSize = true;
            this.labeltxtNdF.Location = new System.Drawing.Point(116, 36);
            this.labeltxtNdF.Name = "labeltxtNdF";
            this.labeltxtNdF.Size = new System.Drawing.Size(68, 13);
            this.labeltxtNdF.TabIndex = 31;
            this.labeltxtNdF.Text = "Noeud fermé";
            // 
            // labeltxtNdO
            // 
            this.labeltxtNdO.AutoSize = true;
            this.labeltxtNdO.Location = new System.Drawing.Point(22, 37);
            this.labeltxtNdO.Name = "labeltxtNdO";
            this.labeltxtNdO.Size = new System.Drawing.Size(72, 13);
            this.labeltxtNdO.TabIndex = 30;
            this.labeltxtNdO.Text = "Noeud ouvert";
            // 
            // labelNdInit
            // 
            this.labelNdInit.AutoSize = true;
            this.labelNdInit.Location = new System.Drawing.Point(200, 113);
            this.labelNdInit.Name = "labelNdInit";
            this.labelNdInit.Size = new System.Drawing.Size(13, 13);
            this.labelNdInit.TabIndex = 32;
            this.labelNdInit.Text = "0";
            // 
            // labelNdFinal
            // 
            this.labelNdFinal.AutoSize = true;
            this.labelNdFinal.Location = new System.Drawing.Point(350, 113);
            this.labelNdFinal.Name = "labelNdFinal";
            this.labelNdFinal.Size = new System.Drawing.Size(13, 13);
            this.labelNdFinal.TabIndex = 33;
            this.labelNdFinal.Text = "0";
            // 
            // checkedListBox_NdO
            // 
            this.checkedListBox_NdO.CheckOnClick = true;
            this.checkedListBox_NdO.FormattingEnabled = true;
            this.checkedListBox_NdO.Location = new System.Drawing.Point(25, 52);
            this.checkedListBox_NdO.Name = "checkedListBox_NdO";
            this.checkedListBox_NdO.Size = new System.Drawing.Size(89, 139);
            this.checkedListBox_NdO.TabIndex = 50;
            // 
            // checkedListBox_NdF
            // 
            this.checkedListBox_NdF.CheckOnClick = true;
            this.checkedListBox_NdF.FormattingEnabled = true;
            this.checkedListBox_NdF.Location = new System.Drawing.Point(119, 53);
            this.checkedListBox_NdF.Name = "checkedListBox_NdF";
            this.checkedListBox_NdF.Size = new System.Drawing.Size(89, 139);
            this.checkedListBox_NdF.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValiderNd);
            this.groupBox1.Controls.Add(this.checkedListBox_NdO);
            this.groupBox1.Controls.Add(this.checkedListBox_NdF);
            this.groupBox1.Controls.Add(this.btnEnvoyer);
            this.groupBox1.Controls.Add(this.listBox_NdO);
            this.groupBox1.Controls.Add(this.labeltxtNdF);
            this.groupBox1.Controls.Add(this.labellistbox);
            this.groupBox1.Controls.Add(this.labeltxtNdO);
            this.groupBox1.Controls.Add(this.listBox_NdF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 249);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithme Dijtstra";
            // 
            // btnValiderNd
            // 
            this.btnValiderNd.Location = new System.Drawing.Point(288, 203);
            this.btnValiderNd.Name = "btnValiderNd";
            this.btnValiderNd.Size = new System.Drawing.Size(98, 31);
            this.btnValiderNd.TabIndex = 52;
            this.btnValiderNd.Text = "Valider";
            this.btnValiderNd.UseVisualStyleBackColor = true;
            this.btnValiderNd.Click += new System.EventHandler(this.btnValiderNd_Click);
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(11, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(145, 173);
            this.treeView1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnValiderTree);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Location = new System.Drawing.Point(473, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 249);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arbre";
            // 
            // btnValiderTree
            // 
            this.btnValiderTree.Location = new System.Drawing.Point(31, 203);
            this.btnValiderTree.Name = "btnValiderTree";
            this.btnValiderTree.Size = new System.Drawing.Size(98, 31);
            this.btnValiderTree.TabIndex = 53;
            this.btnValiderTree.Text = "Valider";
            this.btnValiderTree.UseVisualStyleBackColor = true;
            this.btnValiderTree.Click += new System.EventHandler(this.btnValiderTree_Click);
            // 
            // treeView2
            // 
            this.treeView2.FullRowSelect = true;
            this.treeView2.LabelEdit = true;
            this.treeView2.Location = new System.Drawing.Point(11, 19);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(145, 173);
            this.treeView2.TabIndex = 9;
            this.treeView2.Visible = false;
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Location = new System.Drawing.Point(280, 600);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(98, 31);
            this.buttonTerminer.TabIndex = 52;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.UseVisualStyleBackColor = true;
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Dijkstra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(629, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNdFinal);
            this.Controls.Add(this.labelNdInit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxgraphe1);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxgraphe1;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.ListBox listBox_NdO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labellistbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_NdF;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Label labeltxtNdF;
        private System.Windows.Forms.Label labeltxtNdO;
        private System.Windows.Forms.Label labelNdInit;
        private System.Windows.Forms.Label labelNdFinal;
        private System.Windows.Forms.CheckedListBox checkedListBox_NdO;
        private System.Windows.Forms.CheckedListBox checkedListBox_NdF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonTerminer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValiderNd;
        private System.Windows.Forms.Button btnValiderTree;
        private System.Windows.Forms.TreeView treeView2;
    }
}