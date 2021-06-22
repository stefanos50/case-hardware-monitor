namespace CaseHardwareMonitor
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CPU_NAME = new System.Windows.Forms.Label();
            this.cpu_usage_progress = new CircularProgressBar.CircularProgressBar();
            this.cpu_temperature = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GPU_NAME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpu_temp_progress = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.gpu_usage_progress = new CircularProgressBar.CircularProgressBar();
            this.MEMORY_NAME = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ram_usage_progress = new CircularProgressBar.CircularProgressBar();
            this.ram_gb_label = new System.Windows.Forms.Label();
            this.ram_speed_label = new System.Windows.Forms.Label();
            this.ram_manufacturer_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ram_type_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.core_clock_label = new System.Windows.Forms.Label();
            this.gpu_power_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cpu_power_label = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cpu_core_clock_label = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.gpu_fans_label = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.night_mode_toggle = new CaseHardwareMonitor.Toggle();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CPU_NAME
            // 
            this.CPU_NAME.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU_NAME.Location = new System.Drawing.Point(60, -2);
            this.CPU_NAME.Name = "CPU_NAME";
            this.CPU_NAME.Size = new System.Drawing.Size(412, 67);
            this.CPU_NAME.TabIndex = 7;
            this.CPU_NAME.Text = "CPU TITLE";
            this.CPU_NAME.Click += new System.EventHandler(this.CPU_NAME_Click);
            // 
            // cpu_usage_progress
            // 
            this.cpu_usage_progress.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cpu_usage_progress.AnimationFunction")));
            this.cpu_usage_progress.AnimationSpeed = 500;
            this.cpu_usage_progress.BackColor = System.Drawing.Color.White;
            this.cpu_usage_progress.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_usage_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_usage_progress.InnerColor = System.Drawing.Color.White;
            this.cpu_usage_progress.InnerMargin = 2;
            this.cpu_usage_progress.InnerWidth = -1;
            this.cpu_usage_progress.Location = new System.Drawing.Point(3, 94);
            this.cpu_usage_progress.MarqueeAnimationSpeed = 2000;
            this.cpu_usage_progress.Name = "cpu_usage_progress";
            this.cpu_usage_progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_usage_progress.OuterMargin = -25;
            this.cpu_usage_progress.OuterWidth = 26;
            this.cpu_usage_progress.ProgressColor = System.Drawing.Color.LimeGreen;
            this.cpu_usage_progress.ProgressWidth = 25;
            this.cpu_usage_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_usage_progress.Size = new System.Drawing.Size(168, 167);
            this.cpu_usage_progress.StartAngle = 270;
            this.cpu_usage_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_usage_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpu_usage_progress.SubscriptText = "%";
            this.cpu_usage_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpu_usage_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpu_usage_progress.SuperscriptText = "";
            this.cpu_usage_progress.TabIndex = 9;
            this.cpu_usage_progress.Text = "10";
            this.cpu_usage_progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpu_usage_progress.Value = 15;
            // 
            // cpu_temperature
            // 
            this.cpu_temperature.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cpu_temperature.AnimationFunction")));
            this.cpu_temperature.AnimationSpeed = 500;
            this.cpu_temperature.BackColor = System.Drawing.Color.White;
            this.cpu_temperature.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_temperature.InnerColor = System.Drawing.Color.White;
            this.cpu_temperature.InnerMargin = 2;
            this.cpu_temperature.InnerWidth = -1;
            this.cpu_temperature.Location = new System.Drawing.Point(305, 94);
            this.cpu_temperature.MarqueeAnimationSpeed = 2000;
            this.cpu_temperature.Name = "cpu_temperature";
            this.cpu_temperature.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_temperature.OuterMargin = -25;
            this.cpu_temperature.OuterWidth = 26;
            this.cpu_temperature.ProgressColor = System.Drawing.Color.OrangeRed;
            this.cpu_temperature.ProgressWidth = 25;
            this.cpu_temperature.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_temperature.Size = new System.Drawing.Size(168, 167);
            this.cpu_temperature.StartAngle = 270;
            this.cpu_temperature.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_temperature.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpu_temperature.SubscriptText = "°C";
            this.cpu_temperature.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpu_temperature.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpu_temperature.SuperscriptText = "";
            this.cpu_temperature.TabIndex = 10;
            this.cpu_temperature.Text = "10";
            this.cpu_temperature.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpu_temperature.Value = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Temperature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usage";
            // 
            // GPU_NAME
            // 
            this.GPU_NAME.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU_NAME.Location = new System.Drawing.Point(82, 275);
            this.GPU_NAME.Name = "GPU_NAME";
            this.GPU_NAME.Size = new System.Drawing.Size(400, 30);
            this.GPU_NAME.TabIndex = 15;
            this.GPU_NAME.Text = "GPU TITLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Temperature";
            // 
            // gpu_temp_progress
            // 
            this.gpu_temp_progress.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("gpu_temp_progress.AnimationFunction")));
            this.gpu_temp_progress.AnimationSpeed = 500;
            this.gpu_temp_progress.BackColor = System.Drawing.Color.White;
            this.gpu_temp_progress.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_temp_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_temp_progress.InnerColor = System.Drawing.Color.White;
            this.gpu_temp_progress.InnerMargin = 2;
            this.gpu_temp_progress.InnerWidth = -1;
            this.gpu_temp_progress.Location = new System.Drawing.Point(305, 354);
            this.gpu_temp_progress.MarqueeAnimationSpeed = 2000;
            this.gpu_temp_progress.Name = "gpu_temp_progress";
            this.gpu_temp_progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_temp_progress.OuterMargin = -25;
            this.gpu_temp_progress.OuterWidth = 26;
            this.gpu_temp_progress.ProgressColor = System.Drawing.Color.Crimson;
            this.gpu_temp_progress.ProgressWidth = 25;
            this.gpu_temp_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_temp_progress.Size = new System.Drawing.Size(168, 167);
            this.gpu_temp_progress.StartAngle = 270;
            this.gpu_temp_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_temp_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.gpu_temp_progress.SubscriptText = "°C";
            this.gpu_temp_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpu_temp_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.gpu_temp_progress.SuperscriptText = "";
            this.gpu_temp_progress.TabIndex = 17;
            this.gpu_temp_progress.Text = "10";
            this.gpu_temp_progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.gpu_temp_progress.Value = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usage";
            // 
            // gpu_usage_progress
            // 
            this.gpu_usage_progress.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("gpu_usage_progress.AnimationFunction")));
            this.gpu_usage_progress.AnimationSpeed = 500;
            this.gpu_usage_progress.BackColor = System.Drawing.Color.White;
            this.gpu_usage_progress.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_usage_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_usage_progress.InnerColor = System.Drawing.Color.White;
            this.gpu_usage_progress.InnerMargin = 2;
            this.gpu_usage_progress.InnerWidth = -1;
            this.gpu_usage_progress.Location = new System.Drawing.Point(3, 354);
            this.gpu_usage_progress.MarqueeAnimationSpeed = 2000;
            this.gpu_usage_progress.Name = "gpu_usage_progress";
            this.gpu_usage_progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_usage_progress.OuterMargin = -25;
            this.gpu_usage_progress.OuterWidth = 26;
            this.gpu_usage_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gpu_usage_progress.ProgressWidth = 25;
            this.gpu_usage_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_usage_progress.Size = new System.Drawing.Size(168, 167);
            this.gpu_usage_progress.StartAngle = 270;
            this.gpu_usage_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu_usage_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.gpu_usage_progress.SubscriptText = "%";
            this.gpu_usage_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpu_usage_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.gpu_usage_progress.SuperscriptText = "";
            this.gpu_usage_progress.TabIndex = 20;
            this.gpu_usage_progress.Text = "10";
            this.gpu_usage_progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.gpu_usage_progress.Value = 15;
            // 
            // MEMORY_NAME
            // 
            this.MEMORY_NAME.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEMORY_NAME.Location = new System.Drawing.Point(84, 524);
            this.MEMORY_NAME.Name = "MEMORY_NAME";
            this.MEMORY_NAME.Size = new System.Drawing.Size(397, 62);
            this.MEMORY_NAME.TabIndex = 23;
            this.MEMORY_NAME.Text = "RAM TITLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Usage";
            // 
            // ram_usage_progress
            // 
            this.ram_usage_progress.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ram_usage_progress.AnimationFunction")));
            this.ram_usage_progress.AnimationSpeed = 500;
            this.ram_usage_progress.BackColor = System.Drawing.Color.White;
            this.ram_usage_progress.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_usage_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ram_usage_progress.InnerColor = System.Drawing.Color.White;
            this.ram_usage_progress.InnerMargin = 2;
            this.ram_usage_progress.InnerWidth = -1;
            this.ram_usage_progress.Location = new System.Drawing.Point(290, 589);
            this.ram_usage_progress.MarqueeAnimationSpeed = 2000;
            this.ram_usage_progress.Name = "ram_usage_progress";
            this.ram_usage_progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ram_usage_progress.OuterMargin = -25;
            this.ram_usage_progress.OuterWidth = 26;
            this.ram_usage_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ram_usage_progress.ProgressWidth = 25;
            this.ram_usage_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_usage_progress.Size = new System.Drawing.Size(164, 161);
            this.ram_usage_progress.StartAngle = 270;
            this.ram_usage_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ram_usage_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ram_usage_progress.SubscriptText = "%";
            this.ram_usage_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ram_usage_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ram_usage_progress.SuperscriptText = "";
            this.ram_usage_progress.TabIndex = 28;
            this.ram_usage_progress.Text = "10";
            this.ram_usage_progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ram_usage_progress.Value = 15;
            // 
            // ram_gb_label
            // 
            this.ram_gb_label.AutoSize = true;
            this.ram_gb_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_gb_label.Location = new System.Drawing.Point(6, 16);
            this.ram_gb_label.Name = "ram_gb_label";
            this.ram_gb_label.Size = new System.Drawing.Size(48, 23);
            this.ram_gb_label.TabIndex = 29;
            this.ram_gb_label.Text = "Size";
            // 
            // ram_speed_label
            // 
            this.ram_speed_label.AutoSize = true;
            this.ram_speed_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_speed_label.Location = new System.Drawing.Point(6, 39);
            this.ram_speed_label.Name = "ram_speed_label";
            this.ram_speed_label.Size = new System.Drawing.Size(66, 23);
            this.ram_speed_label.TabIndex = 30;
            this.ram_speed_label.Text = "Speed";
            // 
            // ram_manufacturer_label
            // 
            this.ram_manufacturer_label.AutoSize = true;
            this.ram_manufacturer_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_manufacturer_label.Location = new System.Drawing.Point(6, 84);
            this.ram_manufacturer_label.Name = "ram_manufacturer_label";
            this.ram_manufacturer_label.Size = new System.Drawing.Size(142, 23);
            this.ram_manufacturer_label.TabIndex = 31;
            this.ram_manufacturer_label.Text = "Manufacturer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ram_type_label);
            this.groupBox1.Controls.Add(this.ram_gb_label);
            this.groupBox1.Controls.Add(this.ram_manufacturer_label);
            this.groupBox1.Controls.Add(this.ram_speed_label);
            this.groupBox1.Location = new System.Drawing.Point(3, 604);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 116);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ram_type_label
            // 
            this.ram_type_label.AutoSize = true;
            this.ram_type_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_type_label.Location = new System.Drawing.Point(6, 62);
            this.ram_type_label.Name = "ram_type_label";
            this.ram_type_label.Size = new System.Drawing.Size(57, 23);
            this.ram_type_label.TabIndex = 32;
            this.ram_type_label.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "GPU Core";
            // 
            // core_clock_label
            // 
            this.core_clock_label.AutoSize = true;
            this.core_clock_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core_clock_label.Location = new System.Drawing.Point(201, 383);
            this.core_clock_label.Name = "core_clock_label";
            this.core_clock_label.Size = new System.Drawing.Size(89, 28);
            this.core_clock_label.TabIndex = 35;
            this.core_clock_label.Text = "GPU Core";
            this.core_clock_label.Click += new System.EventHandler(this.core_clock_label_Click);
            // 
            // gpu_power_label
            // 
            this.gpu_power_label.AutoSize = true;
            this.gpu_power_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_power_label.Location = new System.Drawing.Point(203, 434);
            this.gpu_power_label.Name = "gpu_power_label";
            this.gpu_power_label.Size = new System.Drawing.Size(92, 28);
            this.gpu_power_label.TabIndex = 38;
            this.gpu_power_label.Text = "GPU PWR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "GPU Pwr";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CaseHardwareMonitor.Properties.Resources.power_icon;
            this.pictureBox10.Location = new System.Drawing.Point(172, 410);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(33, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 37;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CaseHardwareMonitor.Properties.Resources.speed_icon;
            this.pictureBox9.Location = new System.Drawing.Point(167, 360);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(33, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CaseHardwareMonitor.Properties.Resources.usage_icon;
            this.pictureBox8.Location = new System.Drawing.Point(305, 557);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CaseHardwareMonitor.Properties.Resources.ram_icon;
            this.pictureBox7.Location = new System.Drawing.Point(0, 524);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(78, 74);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CaseHardwareMonitor.Properties.Resources.usage_icon;
            this.pictureBox6.Location = new System.Drawing.Point(3, 319);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CaseHardwareMonitor.Properties.Resources.temp_icon;
            this.pictureBox5.Location = new System.Drawing.Point(267, 319);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CaseHardwareMonitor.Properties.Resources.gpu_icon;
            this.pictureBox4.Location = new System.Drawing.Point(0, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CaseHardwareMonitor.Properties.Resources.usage_icon;
            this.pictureBox3.Location = new System.Drawing.Point(9, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CaseHardwareMonitor.Properties.Resources.temp_icon;
            this.pictureBox2.Location = new System.Drawing.Point(267, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaseHardwareMonitor.Properties.Resources.cpu_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cpu_power_label
            // 
            this.cpu_power_label.AutoSize = true;
            this.cpu_power_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_power_label.Location = new System.Drawing.Point(207, 216);
            this.cpu_power_label.Name = "cpu_power_label";
            this.cpu_power_label.Size = new System.Drawing.Size(91, 28);
            this.cpu_power_label.TabIndex = 44;
            this.cpu_power_label.Text = "CPU PWR";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::CaseHardwareMonitor.Properties.Resources.power_icon;
            this.pictureBox11.Location = new System.Drawing.Point(172, 183);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 43;
            this.pictureBox11.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "CPU Pwr";
            // 
            // cpu_core_clock_label
            // 
            this.cpu_core_clock_label.AutoSize = true;
            this.cpu_core_clock_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_core_clock_label.Location = new System.Drawing.Point(177, 143);
            this.cpu_core_clock_label.Name = "cpu_core_clock_label";
            this.cpu_core_clock_label.Size = new System.Drawing.Size(88, 28);
            this.cpu_core_clock_label.TabIndex = 41;
            this.cpu_core_clock_label.Text = "CPU Core";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::CaseHardwareMonitor.Properties.Resources.speed_icon;
            this.pictureBox12.Location = new System.Drawing.Point(172, 111);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 40;
            this.pictureBox12.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "CPU Core";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Fans";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::CaseHardwareMonitor.Properties.Resources.fan_icon;
            this.pictureBox13.Location = new System.Drawing.Point(172, 456);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 29);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 46;
            this.pictureBox13.TabStop = false;
            // 
            // gpu_fans_label
            // 
            this.gpu_fans_label.AutoSize = true;
            this.gpu_fans_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_fans_label.Location = new System.Drawing.Point(207, 485);
            this.gpu_fans_label.Name = "gpu_fans_label";
            this.gpu_fans_label.Size = new System.Drawing.Size(87, 28);
            this.gpu_fans_label.TabIndex = 47;
            this.gpu_fans_label.Text = "GPU FAN";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::CaseHardwareMonitor.Properties.Resources.night_icon;
            this.pictureBox14.Location = new System.Drawing.Point(9, 726);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(33, 33);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 49;
            this.pictureBox14.TabStop = false;
            // 
            // night_mode_toggle
            // 
            this.night_mode_toggle.Location = new System.Drawing.Point(47, 731);
            this.night_mode_toggle.Name = "night_mode_toggle";
            this.night_mode_toggle.Padding = new System.Windows.Forms.Padding(6);
            this.night_mode_toggle.Size = new System.Drawing.Size(50, 19);
            this.night_mode_toggle.TabIndex = 50;
            this.night_mode_toggle.Load += new System.EventHandler(this.toggle1_Load);
            this.night_mode_toggle.Click += new System.EventHandler(this.night_mode_toggle_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.night_mode_toggle);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.gpu_fans_label);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cpu_power_label);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cpu_core_clock_label);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gpu_power_label);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.core_clock_label);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ram_usage_progress);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.MEMORY_NAME);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpu_usage_progress);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpu_temp_progress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.GPU_NAME);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpu_temperature);
            this.Controls.Add(this.cpu_usage_progress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CPU_NAME);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Case Hardware Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label CPU_NAME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar cpu_usage_progress;
        private CircularProgressBar.CircularProgressBar cpu_temperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label GPU_NAME;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar gpu_temp_progress;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar gpu_usage_progress;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label MEMORY_NAME;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar ram_usage_progress;
        private System.Windows.Forms.Label ram_gb_label;
        private System.Windows.Forms.Label ram_speed_label;
        private System.Windows.Forms.Label ram_manufacturer_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label core_clock_label;
        private System.Windows.Forms.Label gpu_power_label;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cpu_power_label;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cpu_core_clock_label;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ram_type_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label gpu_fans_label;
        private System.Windows.Forms.PictureBox pictureBox14;
        private Toggle night_mode_toggle;
    }
}

