namespace Practice_2nd_corce
{
    partial class Create_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_New));
            this.label_create = new System.Windows.Forms.Label();
            this.create_tabs = new System.Windows.Forms.TabControl();
            this.create_bacteria = new System.Windows.Forms.TabPage();
            this.create_virus = new System.Windows.Forms.TabPage();
            this.create_fungus = new System.Windows.Forms.TabPage();
            this.Create_Button = new yt_DesignUI.yt_Button();
            this.create_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_create
            // 
            this.label_create.AutoSize = true;
            this.label_create.BackColor = System.Drawing.Color.LightCyan;
            this.label_create.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_create.Location = new System.Drawing.Point(78, 71);
            this.label_create.Name = "label_create";
            this.label_create.Size = new System.Drawing.Size(482, 43);
            this.label_create.TabIndex = 0;
            this.label_create.Text = "Создайте микроорганизм:";
            // 
            // create_tabs
            // 
            this.create_tabs.Controls.Add(this.create_bacteria);
            this.create_tabs.Controls.Add(this.create_virus);
            this.create_tabs.Controls.Add(this.create_fungus);
            this.create_tabs.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_tabs.HotTrack = true;
            this.create_tabs.ItemSize = new System.Drawing.Size(100, 40);
            this.create_tabs.Location = new System.Drawing.Point(86, 164);
            this.create_tabs.Name = "create_tabs";
            this.create_tabs.Padding = new System.Drawing.Point(10, 5);
            this.create_tabs.SelectedIndex = 0;
            this.create_tabs.Size = new System.Drawing.Size(797, 540);
            this.create_tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.create_tabs.TabIndex = 1;
            this.create_tabs.TabStop = false;
            // 
            // create_bacteria
            // 
            this.create_bacteria.BackColor = System.Drawing.Color.Honeydew;
            this.create_bacteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_bacteria.Location = new System.Drawing.Point(4, 44);
            this.create_bacteria.Name = "create_bacteria";
            this.create_bacteria.Padding = new System.Windows.Forms.Padding(3);
            this.create_bacteria.Size = new System.Drawing.Size(789, 492);
            this.create_bacteria.TabIndex = 0;
            this.create_bacteria.Text = "Бактерия";
            // 
            // create_virus
            // 
            this.create_virus.BackColor = System.Drawing.Color.MistyRose;
            this.create_virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_virus.Location = new System.Drawing.Point(4, 44);
            this.create_virus.Name = "create_virus";
            this.create_virus.Padding = new System.Windows.Forms.Padding(3);
            this.create_virus.Size = new System.Drawing.Size(789, 492);
            this.create_virus.TabIndex = 1;
            this.create_virus.Text = "Вирус";
            // 
            // create_fungus
            // 
            this.create_fungus.BackColor = System.Drawing.Color.Lavender;
            this.create_fungus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_fungus.Location = new System.Drawing.Point(4, 44);
            this.create_fungus.Name = "create_fungus";
            this.create_fungus.Padding = new System.Windows.Forms.Padding(3);
            this.create_fungus.Size = new System.Drawing.Size(789, 492);
            this.create_fungus.TabIndex = 2;
            this.create_fungus.Text = "Грибок";
            // 
            // Create_Button
            // 
            this.Create_Button.BackColor = System.Drawing.Color.Cyan;
            this.Create_Button.BackColorAdditional = System.Drawing.Color.Navy;
            this.Create_Button.BackColorGradientEnabled = true;
            this.Create_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Create_Button.BorderColor = System.Drawing.Color.Navy;
            this.Create_Button.BorderColorEnabled = false;
            this.Create_Button.BorderColorOnHover = System.Drawing.Color.Blue;
            this.Create_Button.BorderColorOnHoverEnabled = false;
            this.Create_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Button.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Button.ForeColor = System.Drawing.Color.Lavender;
            this.Create_Button.Location = new System.Drawing.Point(367, 738);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.RippleColor = System.Drawing.Color.Yellow;
            this.Create_Button.RoundingEnable = true;
            this.Create_Button.Size = new System.Drawing.Size(274, 57);
            this.Create_Button.TabIndex = 2;
            this.Create_Button.Text = "Создать";
            this.Create_Button.TextHover = null;
            this.Create_Button.UseDownPressEffectOnClick = true;
            this.Create_Button.UseRippleEffect = true;
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.UseZoomEffectOnHover = false;
            // 
            // Create_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.create_tabs);
            this.Controls.Add(this.label_create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Create_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New";
            this.create_tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.TabControl create_tabs;
        private System.Windows.Forms.TabPage create_bacteria;
        private System.Windows.Forms.TabPage create_virus;
        private System.Windows.Forms.TabPage create_fungus;
        private yt_DesignUI.yt_Button Create_Button;
    }
}