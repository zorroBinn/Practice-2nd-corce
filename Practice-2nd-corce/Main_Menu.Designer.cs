namespace Practice_2nd_corce
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Main_Menu_Gif = new System.Windows.Forms.PictureBox();
            this.Main_Menu_Start_Button = new yt_DesignUI.yt_Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Menu_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Menu_Gif
            // 
            this.Main_Menu_Gif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Menu_Gif.Image = ((System.Drawing.Image)(resources.GetObject("Main_Menu_Gif.Image")));
            this.Main_Menu_Gif.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu_Gif.Name = "Main_Menu_Gif";
            this.Main_Menu_Gif.Size = new System.Drawing.Size(1584, 861);
            this.Main_Menu_Gif.TabIndex = 0;
            this.Main_Menu_Gif.TabStop = false;
            this.Main_Menu_Gif.WaitOnLoad = true;
            // 
            // Main_Menu_Start_Button
            // 
            this.Main_Menu_Start_Button.BackColor = System.Drawing.Color.Cyan;
            this.Main_Menu_Start_Button.BackColorAdditional = System.Drawing.Color.MidnightBlue;
            this.Main_Menu_Start_Button.BackColorGradientEnabled = true;
            this.Main_Menu_Start_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Main_Menu_Start_Button.BorderColor = System.Drawing.Color.Cyan;
            this.Main_Menu_Start_Button.BorderColorEnabled = true;
            this.Main_Menu_Start_Button.BorderColorOnHover = System.Drawing.Color.Lime;
            this.Main_Menu_Start_Button.BorderColorOnHoverEnabled = true;
            this.Main_Menu_Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Main_Menu_Start_Button.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Menu_Start_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Main_Menu_Start_Button.Location = new System.Drawing.Point(622, 392);
            this.Main_Menu_Start_Button.Name = "Main_Menu_Start_Button";
            this.Main_Menu_Start_Button.RippleColor = System.Drawing.Color.Lime;
            this.Main_Menu_Start_Button.RoundingEnable = true;
            this.Main_Menu_Start_Button.Size = new System.Drawing.Size(261, 63);
            this.Main_Menu_Start_Button.TabIndex = 1;
            this.Main_Menu_Start_Button.Text = "Начать";
            this.Main_Menu_Start_Button.TextHover = null;
            this.Main_Menu_Start_Button.UseDownPressEffectOnClick = true;
            this.Main_Menu_Start_Button.UseRippleEffect = true;
            this.Main_Menu_Start_Button.UseVisualStyleBackColor = false;
            this.Main_Menu_Start_Button.UseZoomEffectOnHover = false;
            this.Main_Menu_Start_Button.Click += new System.EventHandler(this.Main_Menu_Start_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(643, 832);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by Ivan Sosnin PI-11";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Main_Menu_Start_Button);
            this.Controls.Add(this.Main_Menu_Gif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epidemic Inception";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Menu_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_Menu_Gif;
        private yt_DesignUI.yt_Button Main_Menu_Start_Button;
        private System.Windows.Forms.Label label1;
    }
}