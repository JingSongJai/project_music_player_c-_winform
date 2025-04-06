namespace ProjectMusicPlayerV2
{
    partial class Form1
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
            AntdUI.TreeItem treeItem1 = new AntdUI.TreeItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AntdUI.TreeItem treeItem2 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem3 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem4 = new AntdUI.TreeItem();
            this.windowBar1 = new AntdUI.WindowBar();
            this.button2 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.tree1 = new AntdUI.Tree();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windowBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowBar1
            // 
            this.windowBar1.CloseSize = 30;
            this.windowBar1.Controls.Add(this.button2);
            this.windowBar1.Controls.Add(this.button1);
            this.windowBar1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar1.ForeColor = System.Drawing.Color.Black;
            this.windowBar1.Location = new System.Drawing.Point(-1, 0);
            this.windowBar1.MaximizeBox = false;
            this.windowBar1.MinimizeBox = false;
            this.windowBar1.Mode = AntdUI.TAMode.Light;
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.ShowIcon = false;
            this.windowBar1.Size = new System.Drawing.Size(1005, 49);
            this.windowBar1.SubText = "JingSong";
            this.windowBar1.TabIndex = 0;
            this.windowBar1.Text = "Amazing Music Player";
            this.windowBar1.UseLeft = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(871, 3);
            this.button2.Name = "button2";
            this.button2.Radius = 5;
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "—";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(917, 3);
            this.button1.Name = "button1";
            this.button1.Radius = 5;
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "✕";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tree1
            // 
            this.tree1.BlockNode = true;
            this.tree1.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree1.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            treeItem1.Icon = ((System.Drawing.Image)(resources.GetObject("treeItem1.Icon")));
            treeItem1.PARENTITEM = null;
            treeItem1.Select = true;
            treeItem1.Text = "Music";
            treeItem2.Icon = ((System.Drawing.Image)(resources.GetObject("treeItem2.Icon")));
            treeItem2.PARENTITEM = null;
            treeItem2.Text = "Playlist";
            treeItem3.Icon = ((System.Drawing.Image)(resources.GetObject("treeItem3.Icon")));
            treeItem3.PARENTITEM = null;
            treeItem3.Text = "About Me";
            treeItem4.Icon = ((System.Drawing.Image)(resources.GetObject("treeItem4.Icon")));
            treeItem4.PARENTITEM = null;
            treeItem4.Text = "Exit";
            this.tree1.Items.AddRange(new AntdUI.TreeItem[] {
            treeItem1,
            treeItem2,
            treeItem3,
            treeItem4});
            this.tree1.Location = new System.Drawing.Point(4, 154);
            this.tree1.Name = "tree1";
            this.tree1.Radius = 5;
            this.tree1.Size = new System.Drawing.Size(177, 230);
            this.tree1.TabIndex = 4;
            this.tree1.Text = "tree1";
            this.tree1.SelectChanged += new AntdUI.Tree.SelectEventHandler(this.tree1_SelectChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(185, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 575);
            this.panel2.TabIndex = 5;
            // 
            // panelDisplay
            // 
            this.panelDisplay.Location = new System.Drawing.Point(192, 61);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(755, 670);
            this.panelDisplay.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.windowBar1);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.windowBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.TooltipComponent tooltipComponent1;
        private AntdUI.Tree tree1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal AntdUI.WindowBar windowBar1;
        internal System.Windows.Forms.Panel panelDisplay;
        internal AntdUI.Button button2;
        internal AntdUI.Button button1;
    }
}

