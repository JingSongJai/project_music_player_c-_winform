namespace ProjectMusicPlayerV2.Screens.Components
{
    partial class MusicUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicUserControl));
            this.panel1 = new AntdUI.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconInfo1 = new AntdUI.Icon.IconInfo();
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slider1 = new AntdUI.Slider();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new AntdUI.Panel();
            this.labelDuration = new System.Windows.Forms.Label();
            this.button3 = new AntdUI.Button();
            this.button5 = new AntdUI.Button();
            this.button4 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new AntdUI.Input();
            this.buttonScan = new AntdUI.Button();
            this.labelProcess = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderWidth = 1F;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 5;
            this.panel1.Size = new System.Drawing.Size(746, 429);
            this.panel1.TabIndex = 6;
            this.panel1.Text = "panel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.name,
            this.artist,
            this.duration});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Kantumruy Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(225)))));
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // image
            // 
            this.image.HeaderText = "Column1";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Column1";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // artist
            // 
            this.artist.HeaderText = "Column1";
            this.artist.MinimumWidth = 6;
            this.artist.Name = "artist";
            this.artist.Width = 200;
            // 
            // duration
            // 
            this.duration.HeaderText = "Column1";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.Width = 125;
            // 
            // iconInfo1
            // 
            this.iconInfo1.Location = new System.Drawing.Point(726, 69);
            this.iconInfo1.Name = "iconInfo1";
            this.iconInfo1.Size = new System.Drawing.Size(23, 19);
            this.iconInfo1.TabIndex = 5;
            this.iconInfo1.Text = "iconInfo1";
            this.tooltipComponent1.SetTip(this.iconInfo1, "Support Extensions ( \".wav\", \"mp3\", \".aac\", \".flac\" ) Only!");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.White;
            this.slider1.Dots = new int[0];
            this.slider1.DotSize = 10;
            this.slider1.DotSizeActive = 10;
            this.slider1.Enabled = false;
            this.slider1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.slider1.FillActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.slider1.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.slider1.Location = new System.Drawing.Point(148, 571);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(416, 28);
            this.slider1.TabIndex = 7;
            this.slider1.Text = "slider1";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderWidth = 1F;
            this.panel2.Controls.Add(this.labelDuration);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 534);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 5;
            this.panel2.Shadow = 6;
            this.panel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.ShadowOpacity = 1F;
            this.panel2.Size = new System.Drawing.Size(742, 133);
            this.panel2.TabIndex = 8;
            this.panel2.Text = "panel2";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(572, 50);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(0, 23);
            this.labelDuration.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Image = global::ProjectMusicPlayerV2.Properties.Resources.arrow_left_s_line;
            this.button3.ImageSize = new System.Drawing.Size(30, 30);
            this.button3.Location = new System.Drawing.Point(292, 71);
            this.button3.Name = "button3";
            this.button3.Radius = 10;
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 1;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Image = global::ProjectMusicPlayerV2.Properties.Resources.shuffle_48dp_FILL0_wght100_GRAD0_opsz48;
            this.button5.ImageSize = new System.Drawing.Size(25, 25);
            this.button5.Location = new System.Drawing.Point(246, 75);
            this.button5.Name = "button5";
            this.button5.Radius = 10;
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 1;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::ProjectMusicPlayerV2.Properties.Resources.favorite_48dp_FILL0_wght100_GRAD0_opsz48__2_;
            this.button4.ImageSize = new System.Drawing.Size(25, 25);
            this.button4.Location = new System.Drawing.Point(460, 75);
            this.button4.Name = "button4";
            this.button4.Radius = 10;
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 1;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ProjectMusicPlayerV2.Properties.Resources.arrow_right_s_line;
            this.button2.ImageSize = new System.Drawing.Size(30, 30);
            this.button2.Location = new System.Drawing.Point(404, 71);
            this.button2.Name = "button2";
            this.button2.Radius = 10;
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ProjectMusicPlayerV2.Properties.Resources.Button_Play_Circle__Streamline_Plump__1_;
            this.button1.ImageSize = new System.Drawing.Size(40, 40);
            this.button1.Location = new System.Drawing.Point(348, 71);
            this.button1.Name = "button1";
            this.button1.Radius = 10;
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kantumruy Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 26);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Poppins", 9.8F);
            this.input1.IconRatio = 1.1F;
            this.input1.Location = new System.Drawing.Point(5, 3);
            this.input1.Margins = 7;
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Enter name to search ...";
            this.input1.Prefix = ((System.Drawing.Image)(resources.GetObject("input1.Prefix")));
            this.input1.PrefixSvg = "";
            this.input1.PrefixText = "Search";
            this.input1.Radius = 30;
            this.input1.Size = new System.Drawing.Size(731, 56);
            this.input1.Suffix = ((System.Drawing.Image)(resources.GetObject("input1.Suffix")));
            this.input1.TabIndex = 4;
            this.input1.SuffixClick += new System.Windows.Forms.MouseEventHandler(this.input1_TextChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScan.BorderWidth = 1F;
            this.buttonScan.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonScan.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.buttonScan.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.buttonScan.IconRatio = 1F;
            this.buttonScan.Image = ((System.Drawing.Image)(resources.GetObject("buttonScan.Image")));
            this.buttonScan.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonScan.Location = new System.Drawing.Point(595, 59);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Radius = 5;
            this.buttonScan.Size = new System.Drawing.Size(125, 39);
            this.buttonScan.TabIndex = 11;
            this.buttonScan.Text = "SCAN";
            this.buttonScan.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelProcess
            // 
            this.labelProcess.Font = new System.Drawing.Font("Poppins ExtraLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcess.Location = new System.Drawing.Point(10, 67);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(579, 25);
            this.labelProcess.TabIndex = 12;
            this.labelProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MusicUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconInfo1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MusicUserControl";
            this.Size = new System.Drawing.Size(755, 670);
            this.Load += new System.EventHandler(this.MusicUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Icon.IconInfo iconInfo1;
        private AntdUI.Input input1;
        private AntdUI.TooltipComponent tooltipComponent1;
        private System.Windows.Forms.Timer timer1;
        private AntdUI.Panel panel2;
        private System.Windows.Forms.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Button button3;
        private AntdUI.Button button2;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private AntdUI.Button button4;
        private AntdUI.Button button5;
        internal AntdUI.Slider slider1;
        internal System.Windows.Forms.Timer timer2;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal AntdUI.Button buttonScan;
        private System.Windows.Forms.Label labelProcess;
    }
}
