namespace ProjectMusicPlayerV2.Screens.Components
{
    partial class SettingsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new AntdUI.Button();
            this.checkbox1 = new AntdUI.Checkbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.spin1 = new AntdUI.Spin();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(749, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "v 1.0.1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(67)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(67)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(67)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(67)))));
            this.button1.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(67)))));
            this.button1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IconRatio = 0.8F;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageSize = new System.Drawing.Size(17, 17);
            this.button1.Location = new System.Drawing.Point(122, 464);
            this.button1.Name = "button1";
            this.button1.RespondRealAreas = true;
            this.button1.Shape = AntdUI.TShape.Round;
            this.button1.Size = new System.Drawing.Size(216, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save & Change";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox1
            // 
            this.checkbox1.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(371, 519);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(329, 41);
            this.checkbox1.TabIndex = 3;
            this.checkbox1.Text = "Still play after closing application.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spin1
            // 
            this.spin1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.spin1.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin1.Location = new System.Drawing.Point(3, 74);
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(749, 312);
            this.spin1.TabIndex = 9;
            this.spin1.Text = " ";
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.spin1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbox1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(755, 670);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Button button1;
        private AntdUI.TooltipComponent tooltipComponent1;
        private System.Windows.Forms.Label label6;
        private AntdUI.Spin spin1;
    }
}
