namespace Practice_2nd_corce
{
    partial class Imitation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imitation));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_infection = new System.Windows.Forms.Label();
            this.label_incub = new System.Windows.Forms.Label();
            this.label_illness = new System.Windows.Forms.Label();
            this.label_death = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.infection = new System.Windows.Forms.Label();
            this.percent_infection = new System.Windows.Forms.Label();
            this.incub = new System.Windows.Forms.Label();
            this.illness = new System.Windows.Forms.Label();
            this.death = new System.Windows.Forms.Label();
            this.percent_death = new System.Windows.Forms.Label();
            this.groupBoxSpeed = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.new_mutation_label = new System.Windows.Forms.Label();
            this.pictureBox_Healthy = new System.Windows.Forms.PictureBox();
            this.pictureBox_Incub = new System.Windows.Forms.PictureBox();
            this.pictureBox_Illness = new System.Windows.Forms.PictureBox();
            this.pictureBox_Recovered = new System.Windows.Forms.PictureBox();
            this.pictureBox_Dead = new System.Windows.Forms.PictureBox();
            this.number_of_healthy = new System.Windows.Forms.Label();
            this.number_of_incub = new System.Windows.Forms.Label();
            this.number_of_illness = new System.Windows.Forms.Label();
            this.number_of_recovery = new System.Windows.Forms.Label();
            this.number_of_dead = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.save_into_file_button = new yt_DesignUI.yt_Button();
            this.day_form = new yt_DesignUI.yt_Button();
            this.groupBox_create = new System.Windows.Forms.GroupBox();
            this.checkBox_dead_delete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imitation_start_button = new yt_DesignUI.yt_Button();
            this.numberOfInfected = new System.Windows.Forms.Label();
            this.numberOfPeople = new System.Windows.Forms.Label();
            this.label_numberOfInfected = new System.Windows.Forms.Label();
            this.label_numberOfPeople = new System.Windows.Forms.Label();
            this.trackBar_numberOfInfected = new System.Windows.Forms.TrackBar();
            this.trackBar_numberOfPeople = new System.Windows.Forms.TrackBar();
            this.move_timer = new System.Windows.Forms.Timer(this.components);
            this.new_mutation = new yt_DesignUI.yt_Button();
            this.button_pause = new yt_DesignUI.yt_Button();
            this.button_play = new yt_DesignUI.yt_Button();
            this.button_reset = new yt_DesignUI.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Healthy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Incub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Recovered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dead)).BeginInit();
            this.groupBox_info.SuspendLayout();
            this.groupBox_create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_numberOfInfected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_numberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1050, 825);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_type.ForeColor = System.Drawing.Color.Navy;
            this.label_type.Location = new System.Drawing.Point(1059, 315);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(63, 28);
            this.label_type.TabIndex = 5;
            this.label_type.Text = "Тип:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.Navy;
            this.label_name.Location = new System.Drawing.Point(1220, 253);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(194, 28);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Наименование:";
            // 
            // label_infection
            // 
            this.label_infection.AutoSize = true;
            this.label_infection.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_infection.ForeColor = System.Drawing.Color.Navy;
            this.label_infection.Location = new System.Drawing.Point(1059, 349);
            this.label_infection.Name = "label_infection";
            this.label_infection.Size = new System.Drawing.Size(308, 28);
            this.label_infection.TabIndex = 7;
            this.label_infection.Text = "Вероятность передачи:";
            // 
            // label_incub
            // 
            this.label_incub.AutoSize = true;
            this.label_incub.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_incub.ForeColor = System.Drawing.Color.Navy;
            this.label_incub.Location = new System.Drawing.Point(1059, 389);
            this.label_incub.Name = "label_incub";
            this.label_incub.Size = new System.Drawing.Size(386, 28);
            this.label_incub.TabIndex = 8;
            this.label_incub.Text = "Инкубационный период (дней):";
            // 
            // label_illness
            // 
            this.label_illness.AutoSize = true;
            this.label_illness.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_illness.ForeColor = System.Drawing.Color.Navy;
            this.label_illness.Location = new System.Drawing.Point(1059, 426);
            this.label_illness.Name = "label_illness";
            this.label_illness.Size = new System.Drawing.Size(292, 28);
            this.label_illness.TabIndex = 9;
            this.label_illness.Text = "Период болезни (дней):";
            // 
            // label_death
            // 
            this.label_death.AutoSize = true;
            this.label_death.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_death.ForeColor = System.Drawing.Color.Navy;
            this.label_death.Location = new System.Drawing.Point(1059, 461);
            this.label_death.Name = "label_death";
            this.label_death.Size = new System.Drawing.Size(189, 28);
            this.label_death.TabIndex = 10;
            this.label_death.Text = "Летальность:";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.ForeColor = System.Drawing.Color.Green;
            this.type.Location = new System.Drawing.Point(1415, 313);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(157, 32);
            this.type.TabIndex = 11;
            this.type.Text = "<type>";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.Green;
            this.name.Location = new System.Drawing.Point(1068, 281);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(494, 32);
            this.name.TabIndex = 12;
            this.name.Text = "<name>";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infection
            // 
            this.infection.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infection.ForeColor = System.Drawing.Color.Green;
            this.infection.Location = new System.Drawing.Point(1466, 347);
            this.infection.Name = "infection";
            this.infection.Size = new System.Drawing.Size(64, 32);
            this.infection.TabIndex = 13;
            this.infection.Text = "100";
            this.infection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percent_infection
            // 
            this.percent_infection.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_infection.ForeColor = System.Drawing.Color.Green;
            this.percent_infection.Location = new System.Drawing.Point(1528, 347);
            this.percent_infection.Name = "percent_infection";
            this.percent_infection.Size = new System.Drawing.Size(44, 32);
            this.percent_infection.TabIndex = 14;
            this.percent_infection.Text = "%";
            this.percent_infection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incub
            // 
            this.incub.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incub.ForeColor = System.Drawing.Color.Green;
            this.incub.Location = new System.Drawing.Point(1466, 387);
            this.incub.Name = "incub";
            this.incub.Size = new System.Drawing.Size(64, 32);
            this.incub.TabIndex = 15;
            this.incub.Text = "100";
            this.incub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // illness
            // 
            this.illness.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.illness.ForeColor = System.Drawing.Color.Green;
            this.illness.Location = new System.Drawing.Point(1466, 424);
            this.illness.Name = "illness";
            this.illness.Size = new System.Drawing.Size(64, 32);
            this.illness.TabIndex = 16;
            this.illness.Text = "100";
            this.illness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // death
            // 
            this.death.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.death.ForeColor = System.Drawing.Color.Green;
            this.death.Location = new System.Drawing.Point(1466, 459);
            this.death.Name = "death";
            this.death.Size = new System.Drawing.Size(64, 32);
            this.death.TabIndex = 17;
            this.death.Text = "100";
            this.death.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percent_death
            // 
            this.percent_death.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_death.ForeColor = System.Drawing.Color.Green;
            this.percent_death.Location = new System.Drawing.Point(1528, 459);
            this.percent_death.Name = "percent_death";
            this.percent_death.Size = new System.Drawing.Size(44, 32);
            this.percent_death.TabIndex = 18;
            this.percent_death.Text = "%";
            this.percent_death.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSpeed
            // 
            this.groupBoxSpeed.Controls.Add(this.radioButton4);
            this.groupBoxSpeed.Controls.Add(this.radioButton3);
            this.groupBoxSpeed.Controls.Add(this.radioButton2);
            this.groupBoxSpeed.Controls.Add(this.radioButton1);
            this.groupBoxSpeed.Location = new System.Drawing.Point(828, 845);
            this.groupBoxSpeed.Name = "groupBoxSpeed";
            this.groupBoxSpeed.Size = new System.Drawing.Size(236, 42);
            this.groupBoxSpeed.TabIndex = 23;
            this.groupBoxSpeed.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.ForeColor = System.Drawing.Color.Navy;
            this.radioButton4.Location = new System.Drawing.Point(172, 11);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 27);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "x10";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.Navy;
            this.radioButton3.Location = new System.Drawing.Point(124, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 27);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.Text = "x4";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(72, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 27);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.Text = "x2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Navy;
            this.radioButton1.Location = new System.Drawing.Point(20, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 27);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "x1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // new_mutation_label
            // 
            this.new_mutation_label.AutoSize = true;
            this.new_mutation_label.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_mutation_label.ForeColor = System.Drawing.Color.Navy;
            this.new_mutation_label.Location = new System.Drawing.Point(1096, 671);
            this.new_mutation_label.Name = "new_mutation_label";
            this.new_mutation_label.Size = new System.Drawing.Size(250, 28);
            this.new_mutation_label.TabIndex = 25;
            this.new_mutation_label.Text = "Получена мутация:";
            this.new_mutation_label.Visible = false;
            // 
            // pictureBox_Healthy
            // 
            this.pictureBox_Healthy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox_Healthy.Location = new System.Drawing.Point(493, 12);
            this.pictureBox_Healthy.Name = "pictureBox_Healthy";
            this.pictureBox_Healthy.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Healthy.TabIndex = 26;
            this.pictureBox_Healthy.TabStop = false;
            this.pictureBox_Healthy.MouseHover += new System.EventHandler(this.pictureBox_Healthy_MouseHover);
            // 
            // pictureBox_Incub
            // 
            this.pictureBox_Incub.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox_Incub.Location = new System.Drawing.Point(493, 51);
            this.pictureBox_Incub.Name = "pictureBox_Incub";
            this.pictureBox_Incub.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Incub.TabIndex = 27;
            this.pictureBox_Incub.TabStop = false;
            this.pictureBox_Incub.MouseHover += new System.EventHandler(this.pictureBox_Incub_MouseHover);
            // 
            // pictureBox_Illness
            // 
            this.pictureBox_Illness.BackColor = System.Drawing.Color.Brown;
            this.pictureBox_Illness.Location = new System.Drawing.Point(493, 91);
            this.pictureBox_Illness.Name = "pictureBox_Illness";
            this.pictureBox_Illness.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Illness.TabIndex = 28;
            this.pictureBox_Illness.TabStop = false;
            this.pictureBox_Illness.MouseHover += new System.EventHandler(this.pictureBox_Illness_MouseHover);
            // 
            // pictureBox_Recovered
            // 
            this.pictureBox_Recovered.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox_Recovered.Location = new System.Drawing.Point(493, 132);
            this.pictureBox_Recovered.Name = "pictureBox_Recovered";
            this.pictureBox_Recovered.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Recovered.TabIndex = 29;
            this.pictureBox_Recovered.TabStop = false;
            this.pictureBox_Recovered.MouseHover += new System.EventHandler(this.pictureBox_Recovered_MouseHover);
            // 
            // pictureBox_Dead
            // 
            this.pictureBox_Dead.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Dead.Location = new System.Drawing.Point(493, 172);
            this.pictureBox_Dead.Name = "pictureBox_Dead";
            this.pictureBox_Dead.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Dead.TabIndex = 30;
            this.pictureBox_Dead.TabStop = false;
            this.pictureBox_Dead.MouseHover += new System.EventHandler(this.pictureBox_Dead_MouseHover);
            // 
            // number_of_healthy
            // 
            this.number_of_healthy.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_healthy.ForeColor = System.Drawing.Color.Navy;
            this.number_of_healthy.Location = new System.Drawing.Point(422, 11);
            this.number_of_healthy.Name = "number_of_healthy";
            this.number_of_healthy.Size = new System.Drawing.Size(65, 23);
            this.number_of_healthy.TabIndex = 31;
            this.number_of_healthy.Text = "0";
            this.number_of_healthy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number_of_incub
            // 
            this.number_of_incub.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_incub.ForeColor = System.Drawing.Color.Tomato;
            this.number_of_incub.Location = new System.Drawing.Point(422, 48);
            this.number_of_incub.Name = "number_of_incub";
            this.number_of_incub.Size = new System.Drawing.Size(65, 23);
            this.number_of_incub.TabIndex = 32;
            this.number_of_incub.Text = "0";
            this.number_of_incub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number_of_illness
            // 
            this.number_of_illness.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_illness.ForeColor = System.Drawing.Color.Brown;
            this.number_of_illness.Location = new System.Drawing.Point(422, 88);
            this.number_of_illness.Name = "number_of_illness";
            this.number_of_illness.Size = new System.Drawing.Size(65, 23);
            this.number_of_illness.TabIndex = 33;
            this.number_of_illness.Text = "0";
            this.number_of_illness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number_of_recovery
            // 
            this.number_of_recovery.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_recovery.ForeColor = System.Drawing.Color.LimeGreen;
            this.number_of_recovery.Location = new System.Drawing.Point(422, 129);
            this.number_of_recovery.Name = "number_of_recovery";
            this.number_of_recovery.Size = new System.Drawing.Size(65, 23);
            this.number_of_recovery.TabIndex = 34;
            this.number_of_recovery.Text = "0";
            this.number_of_recovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number_of_dead
            // 
            this.number_of_dead.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_dead.ForeColor = System.Drawing.Color.Black;
            this.number_of_dead.Location = new System.Drawing.Point(422, 169);
            this.number_of_dead.Name = "number_of_dead";
            this.number_of_dead.Size = new System.Drawing.Size(65, 23);
            this.number_of_dead.TabIndex = 35;
            this.number_of_dead.Text = "0";
            this.number_of_dead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.save_into_file_button);
            this.groupBox_info.Controls.Add(this.number_of_healthy);
            this.groupBox_info.Controls.Add(this.number_of_incub);
            this.groupBox_info.Controls.Add(this.number_of_illness);
            this.groupBox_info.Controls.Add(this.number_of_recovery);
            this.groupBox_info.Controls.Add(this.number_of_dead);
            this.groupBox_info.Controls.Add(this.day_form);
            this.groupBox_info.Controls.Add(this.pictureBox_Healthy);
            this.groupBox_info.Controls.Add(this.pictureBox_Incub);
            this.groupBox_info.Controls.Add(this.pictureBox_Illness);
            this.groupBox_info.Controls.Add(this.pictureBox_Recovered);
            this.groupBox_info.Controls.Add(this.pictureBox_Dead);
            this.groupBox_info.Location = new System.Drawing.Point(1059, 1);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(523, 215);
            this.groupBox_info.TabIndex = 36;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Visible = false;
            // 
            // save_into_file_button
            // 
            this.save_into_file_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.save_into_file_button.BackColorAdditional = System.Drawing.Color.Navy;
            this.save_into_file_button.BackColorGradientEnabled = true;
            this.save_into_file_button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.save_into_file_button.BorderColor = System.Drawing.Color.Tomato;
            this.save_into_file_button.BorderColorEnabled = false;
            this.save_into_file_button.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.save_into_file_button.BorderColorOnHoverEnabled = false;
            this.save_into_file_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_into_file_button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_into_file_button.ForeColor = System.Drawing.Color.White;
            this.save_into_file_button.Location = new System.Drawing.Point(137, 142);
            this.save_into_file_button.Name = "save_into_file_button";
            this.save_into_file_button.RippleColor = System.Drawing.Color.Red;
            this.save_into_file_button.RoundingEnable = true;
            this.save_into_file_button.Size = new System.Drawing.Size(227, 50);
            this.save_into_file_button.TabIndex = 38;
            this.save_into_file_button.Text = "Сохранить в файл";
            this.save_into_file_button.TextHover = null;
            this.save_into_file_button.UseDownPressEffectOnClick = true;
            this.save_into_file_button.UseRippleEffect = true;
            this.save_into_file_button.UseVisualStyleBackColor = false;
            this.save_into_file_button.UseZoomEffectOnHover = false;
            this.save_into_file_button.Visible = false;
            // 
            // day_form
            // 
            this.day_form.BackColor = System.Drawing.Color.Red;
            this.day_form.BackColorAdditional = System.Drawing.Color.Black;
            this.day_form.BackColorGradientEnabled = true;
            this.day_form.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.day_form.BorderColor = System.Drawing.Color.Tomato;
            this.day_form.BorderColorEnabled = false;
            this.day_form.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.day_form.BorderColorOnHoverEnabled = false;
            this.day_form.Cursor = System.Windows.Forms.Cursors.Default;
            this.day_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_form.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_form.ForeColor = System.Drawing.Color.White;
            this.day_form.Location = new System.Drawing.Point(6, 11);
            this.day_form.Name = "day_form";
            this.day_form.RippleColor = System.Drawing.Color.Red;
            this.day_form.RoundingEnable = true;
            this.day_form.Size = new System.Drawing.Size(89, 42);
            this.day_form.TabIndex = 19;
            this.day_form.TabStop = false;
            this.day_form.Text = "0";
            this.day_form.TextHover = null;
            this.day_form.UseDownPressEffectOnClick = false;
            this.day_form.UseRippleEffect = false;
            this.day_form.UseVisualStyleBackColor = false;
            this.day_form.UseZoomEffectOnHover = false;
            // 
            // groupBox_create
            // 
            this.groupBox_create.BackColor = System.Drawing.Color.Lavender;
            this.groupBox_create.Controls.Add(this.checkBox_dead_delete);
            this.groupBox_create.Controls.Add(this.label1);
            this.groupBox_create.Controls.Add(this.imitation_start_button);
            this.groupBox_create.Controls.Add(this.numberOfInfected);
            this.groupBox_create.Controls.Add(this.numberOfPeople);
            this.groupBox_create.Controls.Add(this.label_numberOfInfected);
            this.groupBox_create.Controls.Add(this.label_numberOfPeople);
            this.groupBox_create.Controls.Add(this.trackBar_numberOfInfected);
            this.groupBox_create.Controls.Add(this.trackBar_numberOfPeople);
            this.groupBox_create.Location = new System.Drawing.Point(-7, 1);
            this.groupBox_create.Name = "groupBox_create";
            this.groupBox_create.Size = new System.Drawing.Size(1071, 911);
            this.groupBox_create.TabIndex = 37;
            this.groupBox_create.TabStop = false;
            // 
            // checkBox_dead_delete
            // 
            this.checkBox_dead_delete.AutoSize = true;
            this.checkBox_dead_delete.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_dead_delete.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_dead_delete.Location = new System.Drawing.Point(377, 402);
            this.checkBox_dead_delete.Name = "checkBox_dead_delete";
            this.checkBox_dead_delete.Size = new System.Drawing.Size(285, 33);
            this.checkBox_dead_delete.TabIndex = 27;
            this.checkBox_dead_delete.Text = "Убирать умерших с поля";
            this.checkBox_dead_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(143, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "(до 10% от числа людей)";
            // 
            // imitation_start_button
            // 
            this.imitation_start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.imitation_start_button.BackColorAdditional = System.Drawing.Color.Navy;
            this.imitation_start_button.BackColorGradientEnabled = true;
            this.imitation_start_button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.imitation_start_button.BorderColor = System.Drawing.Color.Tomato;
            this.imitation_start_button.BorderColorEnabled = false;
            this.imitation_start_button.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.imitation_start_button.BorderColorOnHoverEnabled = false;
            this.imitation_start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imitation_start_button.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imitation_start_button.ForeColor = System.Drawing.Color.White;
            this.imitation_start_button.Location = new System.Drawing.Point(329, 489);
            this.imitation_start_button.Name = "imitation_start_button";
            this.imitation_start_button.RippleColor = System.Drawing.Color.Black;
            this.imitation_start_button.RoundingEnable = true;
            this.imitation_start_button.Size = new System.Drawing.Size(429, 74);
            this.imitation_start_button.TabIndex = 25;
            this.imitation_start_button.Text = "Начать имитацию";
            this.imitation_start_button.TextHover = null;
            this.imitation_start_button.UseDownPressEffectOnClick = false;
            this.imitation_start_button.UseRippleEffect = false;
            this.imitation_start_button.UseVisualStyleBackColor = false;
            this.imitation_start_button.UseZoomEffectOnHover = false;
            this.imitation_start_button.Click += new System.EventHandler(this.imitation_start_button_Click);
            // 
            // numberOfInfected
            // 
            this.numberOfInfected.AutoSize = true;
            this.numberOfInfected.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfInfected.ForeColor = System.Drawing.Color.Navy;
            this.numberOfInfected.Location = new System.Drawing.Point(692, 314);
            this.numberOfInfected.Name = "numberOfInfected";
            this.numberOfInfected.Size = new System.Drawing.Size(25, 28);
            this.numberOfInfected.TabIndex = 10;
            this.numberOfInfected.Text = "1";
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.AutoSize = true;
            this.numberOfPeople.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfPeople.ForeColor = System.Drawing.Color.Navy;
            this.numberOfPeople.Location = new System.Drawing.Point(692, 189);
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(38, 28);
            this.numberOfPeople.TabIndex = 9;
            this.numberOfPeople.Text = "50";
            // 
            // label_numberOfInfected
            // 
            this.label_numberOfInfected.AutoSize = true;
            this.label_numberOfInfected.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_numberOfInfected.ForeColor = System.Drawing.Color.Navy;
            this.label_numberOfInfected.Location = new System.Drawing.Point(143, 312);
            this.label_numberOfInfected.Name = "label_numberOfInfected";
            this.label_numberOfInfected.Size = new System.Drawing.Size(171, 28);
            this.label_numberOfInfected.TabIndex = 8;
            this.label_numberOfInfected.Text = "Заражённых:";
            // 
            // label_numberOfPeople
            // 
            this.label_numberOfPeople.AutoSize = true;
            this.label_numberOfPeople.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_numberOfPeople.ForeColor = System.Drawing.Color.Navy;
            this.label_numberOfPeople.Location = new System.Drawing.Point(93, 187);
            this.label_numberOfPeople.Name = "label_numberOfPeople";
            this.label_numberOfPeople.Size = new System.Drawing.Size(268, 28);
            this.label_numberOfPeople.TabIndex = 7;
            this.label_numberOfPeople.Text = "Количество человек:";
            // 
            // trackBar_numberOfInfected
            // 
            this.trackBar_numberOfInfected.BackColor = System.Drawing.Color.White;
            this.trackBar_numberOfInfected.Location = new System.Drawing.Point(377, 297);
            this.trackBar_numberOfInfected.Maximum = 5;
            this.trackBar_numberOfInfected.Minimum = 1;
            this.trackBar_numberOfInfected.Name = "trackBar_numberOfInfected";
            this.trackBar_numberOfInfected.Size = new System.Drawing.Size(294, 45);
            this.trackBar_numberOfInfected.TabIndex = 1;
            this.trackBar_numberOfInfected.TabStop = false;
            this.trackBar_numberOfInfected.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_numberOfInfected.Value = 1;
            this.trackBar_numberOfInfected.Scroll += new System.EventHandler(this.trackBar_numberOfInfected_Scroll);
            // 
            // trackBar_numberOfPeople
            // 
            this.trackBar_numberOfPeople.BackColor = System.Drawing.Color.White;
            this.trackBar_numberOfPeople.LargeChange = 10;
            this.trackBar_numberOfPeople.Location = new System.Drawing.Point(377, 172);
            this.trackBar_numberOfPeople.Maximum = 500;
            this.trackBar_numberOfPeople.Minimum = 50;
            this.trackBar_numberOfPeople.Name = "trackBar_numberOfPeople";
            this.trackBar_numberOfPeople.Size = new System.Drawing.Size(294, 45);
            this.trackBar_numberOfPeople.SmallChange = 10;
            this.trackBar_numberOfPeople.TabIndex = 0;
            this.trackBar_numberOfPeople.TabStop = false;
            this.trackBar_numberOfPeople.TickFrequency = 10;
            this.trackBar_numberOfPeople.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_numberOfPeople.Value = 50;
            this.trackBar_numberOfPeople.Scroll += new System.EventHandler(this.trackBar_numberOfPeople_Scroll);
            // 
            // move_timer
            // 
            this.move_timer.Interval = 400;
            this.move_timer.Tick += new System.EventHandler(this.move_timer_Tick);
            // 
            // new_mutation
            // 
            this.new_mutation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.new_mutation.BackColorAdditional = System.Drawing.Color.Navy;
            this.new_mutation.BackColorGradientEnabled = true;
            this.new_mutation.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.new_mutation.BorderColor = System.Drawing.Color.Tomato;
            this.new_mutation.BorderColorEnabled = false;
            this.new_mutation.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.new_mutation.BorderColorOnHoverEnabled = false;
            this.new_mutation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_mutation.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_mutation.ForeColor = System.Drawing.Color.White;
            this.new_mutation.Location = new System.Drawing.Point(1101, 713);
            this.new_mutation.Name = "new_mutation";
            this.new_mutation.RippleColor = System.Drawing.Color.Black;
            this.new_mutation.RoundingEnable = true;
            this.new_mutation.Size = new System.Drawing.Size(429, 74);
            this.new_mutation.TabIndex = 24;
            this.new_mutation.Text = "Вероятность передачи +10";
            this.new_mutation.TextHover = null;
            this.new_mutation.UseDownPressEffectOnClick = false;
            this.new_mutation.UseRippleEffect = false;
            this.new_mutation.UseVisualStyleBackColor = false;
            this.new_mutation.UseZoomEffectOnHover = false;
            this.new_mutation.Visible = false;
            // 
            // button_pause
            // 
            this.button_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_pause.BackColorAdditional = System.Drawing.Color.Navy;
            this.button_pause.BackColorGradientEnabled = true;
            this.button_pause.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.button_pause.BorderColor = System.Drawing.Color.Tomato;
            this.button_pause.BorderColorEnabled = false;
            this.button_pause.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.button_pause.BorderColorOnHoverEnabled = false;
            this.button_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pause.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pause.ForeColor = System.Drawing.Color.White;
            this.button_pause.Location = new System.Drawing.Point(509, 844);
            this.button_pause.Name = "button_pause";
            this.button_pause.RippleColor = System.Drawing.Color.Red;
            this.button_pause.RoundingEnable = true;
            this.button_pause.Size = new System.Drawing.Size(51, 42);
            this.button_pause.TabIndex = 4;
            this.button_pause.Text = " ⏸";
            this.button_pause.TextHover = null;
            this.button_pause.UseDownPressEffectOnClick = true;
            this.button_pause.UseRippleEffect = true;
            this.button_pause.UseVisualStyleBackColor = false;
            this.button_pause.UseZoomEffectOnHover = false;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_play.BackColorAdditional = System.Drawing.Color.Navy;
            this.button_play.BackColorGradientEnabled = true;
            this.button_play.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.button_play.BorderColor = System.Drawing.Color.Tomato;
            this.button_play.BorderColorEnabled = false;
            this.button_play.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.button_play.BorderColorOnHoverEnabled = false;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_play.ForeColor = System.Drawing.Color.White;
            this.button_play.Location = new System.Drawing.Point(452, 844);
            this.button_play.Name = "button_play";
            this.button_play.RippleColor = System.Drawing.Color.Red;
            this.button_play.RoundingEnable = true;
            this.button_play.Size = new System.Drawing.Size(51, 42);
            this.button_play.TabIndex = 3;
            this.button_play.Text = " ▶";
            this.button_play.TextHover = null;
            this.button_play.UseDownPressEffectOnClick = true;
            this.button_play.UseRippleEffect = true;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.UseZoomEffectOnHover = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_reset.BackColorAdditional = System.Drawing.Color.Navy;
            this.button_reset.BackColorGradientEnabled = true;
            this.button_reset.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.button_reset.BorderColor = System.Drawing.Color.Tomato;
            this.button_reset.BorderColorEnabled = false;
            this.button_reset.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.button_reset.BorderColorOnHoverEnabled = false;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(12, 845);
            this.button_reset.Name = "button_reset";
            this.button_reset.RippleColor = System.Drawing.Color.Red;
            this.button_reset.RoundingEnable = true;
            this.button_reset.Size = new System.Drawing.Size(172, 42);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Сбросить";
            this.button_reset.TextHover = null;
            this.button_reset.UseDownPressEffectOnClick = true;
            this.button_reset.UseRippleEffect = true;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.UseZoomEffectOnHover = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Imitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 911);
            this.Controls.Add(this.groupBox_create);
            this.Controls.Add(this.new_mutation_label);
            this.Controls.Add(this.new_mutation);
            this.Controls.Add(this.groupBoxSpeed);
            this.Controls.Add(this.percent_death);
            this.Controls.Add(this.death);
            this.Controls.Add(this.illness);
            this.Controls.Add(this.incub);
            this.Controls.Add(this.percent_infection);
            this.Controls.Add(this.infection);
            this.Controls.Add(this.name);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label_death);
            this.Controls.Add(this.label_illness);
            this.Controls.Add(this.label_incub);
            this.Controls.Add(this.label_infection);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox_info);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 950);
            this.MinimumSize = new System.Drawing.Size(1600, 950);
            this.Name = "Imitation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imitation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Imitation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxSpeed.ResumeLayout(false);
            this.groupBoxSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Healthy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Incub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Recovered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dead)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_create.ResumeLayout(false);
            this.groupBox_create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_numberOfInfected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_numberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private yt_DesignUI.yt_Button button_reset;
        private yt_DesignUI.yt_Button button_play;
        private yt_DesignUI.yt_Button button_pause;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_infection;
        private System.Windows.Forms.Label label_incub;
        private System.Windows.Forms.Label label_illness;
        private System.Windows.Forms.Label label_death;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label infection;
        private System.Windows.Forms.Label percent_infection;
        private System.Windows.Forms.Label incub;
        private System.Windows.Forms.Label illness;
        private System.Windows.Forms.Label death;
        private System.Windows.Forms.Label percent_death;
        private yt_DesignUI.yt_Button day_form;
        private System.Windows.Forms.GroupBox groupBoxSpeed;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private yt_DesignUI.yt_Button new_mutation;
        private System.Windows.Forms.Label new_mutation_label;
        private System.Windows.Forms.PictureBox pictureBox_Healthy;
        private System.Windows.Forms.PictureBox pictureBox_Incub;
        private System.Windows.Forms.PictureBox pictureBox_Illness;
        private System.Windows.Forms.PictureBox pictureBox_Recovered;
        private System.Windows.Forms.PictureBox pictureBox_Dead;
        private System.Windows.Forms.Label number_of_healthy;
        private System.Windows.Forms.Label number_of_incub;
        private System.Windows.Forms.Label number_of_illness;
        private System.Windows.Forms.Label number_of_recovery;
        private System.Windows.Forms.Label number_of_dead;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.GroupBox groupBox_create;
        private System.Windows.Forms.TrackBar trackBar_numberOfPeople;
        private yt_DesignUI.yt_Button imitation_start_button;
        private System.Windows.Forms.Label numberOfInfected;
        private System.Windows.Forms.Label numberOfPeople;
        private System.Windows.Forms.Label label_numberOfInfected;
        private System.Windows.Forms.Label label_numberOfPeople;
        private System.Windows.Forms.TrackBar trackBar_numberOfInfected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer move_timer;
        private yt_DesignUI.yt_Button save_into_file_button;
        private System.Windows.Forms.CheckBox checkBox_dead_delete;
    }
}