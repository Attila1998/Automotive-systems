namespace Oscillation_Damping
{
    partial class Main_Form
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Control_Signal_TextBox = new System.Windows.Forms.TextBox();
            this.Disturbance_Signal = new System.Windows.Forms.Label();
            this.Disturbance_Signal_TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Analog_IN_0_TextBox = new System.Windows.Forms.TextBox();
            this.Analog_IN_1_TextBox = new System.Windows.Forms.TextBox();
            this.Position_Signal_TextBox = new System.Windows.Forms.TextBox();
            this.Velocity_Signal_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Enable_checkBox = new System.Windows.Forms.CheckBox();
            this.Lab_Selector_ComboBox = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Control_Signal_TextBox);
            this.groupBox2.Controls.Add(this.Disturbance_Signal);
            this.groupBox2.Controls.Add(this.Disturbance_Signal_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(104, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 88);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Control Signal";
            // 
            // Control_Signal_TextBox
            // 
            this.Control_Signal_TextBox.Location = new System.Drawing.Point(21, 47);
            this.Control_Signal_TextBox.Name = "Control_Signal_TextBox";
            this.Control_Signal_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Control_Signal_TextBox.TabIndex = 4;
            // 
            // Disturbance_Signal
            // 
            this.Disturbance_Signal.AutoSize = true;
            this.Disturbance_Signal.Location = new System.Drawing.Point(159, 22);
            this.Disturbance_Signal.Name = "Disturbance_Signal";
            this.Disturbance_Signal.Size = new System.Drawing.Size(96, 13);
            this.Disturbance_Signal.TabIndex = 22;
            this.Disturbance_Signal.Text = "Disturbance Signal";
            // 
            // Disturbance_Signal_TextBox
            // 
            this.Disturbance_Signal_TextBox.Location = new System.Drawing.Point(162, 47);
            this.Disturbance_Signal_TextBox.Name = "Disturbance_Signal_TextBox";
            this.Disturbance_Signal_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Disturbance_Signal_TextBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Velocity Signal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Position Signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Analog IN 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Analog IN 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Analog_IN_0_TextBox);
            this.groupBox1.Controls.Add(this.Analog_IN_1_TextBox);
            this.groupBox1.Controls.Add(this.Position_Signal_TextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Velocity_Signal_TextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(103, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 140);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // Analog_IN_0_TextBox
            // 
            this.Analog_IN_0_TextBox.Location = new System.Drawing.Point(17, 50);
            this.Analog_IN_0_TextBox.Name = "Analog_IN_0_TextBox";
            this.Analog_IN_0_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Analog_IN_0_TextBox.TabIndex = 0;
            // 
            // Analog_IN_1_TextBox
            // 
            this.Analog_IN_1_TextBox.Location = new System.Drawing.Point(160, 51);
            this.Analog_IN_1_TextBox.Name = "Analog_IN_1_TextBox";
            this.Analog_IN_1_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Analog_IN_1_TextBox.TabIndex = 1;
            // 
            // Position_Signal_TextBox
            // 
            this.Position_Signal_TextBox.Location = new System.Drawing.Point(18, 100);
            this.Position_Signal_TextBox.Name = "Position_Signal_TextBox";
            this.Position_Signal_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Position_Signal_TextBox.TabIndex = 2;
            // 
            // Velocity_Signal_TextBox
            // 
            this.Velocity_Signal_TextBox.Location = new System.Drawing.Point(160, 101);
            this.Velocity_Signal_TextBox.Name = "Velocity_Signal_TextBox";
            this.Velocity_Signal_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Velocity_Signal_TextBox.TabIndex = 3;
            this.Velocity_Signal_TextBox.TextChanged += new System.EventHandler(this.Velocity_Signal_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selector";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Enable_checkBox
            // 
            this.Enable_checkBox.AutoSize = true;
            this.Enable_checkBox.Location = new System.Drawing.Point(327, 53);
            this.Enable_checkBox.Name = "Enable_checkBox";
            this.Enable_checkBox.Size = new System.Drawing.Size(59, 17);
            this.Enable_checkBox.TabIndex = 26;
            this.Enable_checkBox.Text = "Enable";
            this.Enable_checkBox.UseVisualStyleBackColor = true;
            // 
            // Lab_Selector_ComboBox
            // 
            this.Lab_Selector_ComboBox.FormattingEnabled = true;
            this.Lab_Selector_ComboBox.Items.AddRange(new object[] {
            "Lab - Pulse Test",
            "Lab - Data Save",
            "Lab - PID Control",
            "Lab - State Sapce Control"});
            this.Lab_Selector_ComboBox.Location = new System.Drawing.Point(104, 49);
            this.Lab_Selector_ComboBox.Name = "Lab_Selector_ComboBox";
            this.Lab_Selector_ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Lab_Selector_ComboBox.TabIndex = 25;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enable_checkBox);
            this.Controls.Add(this.Lab_Selector_ComboBox);
            this.Name = "Main_Form";
            this.Text = "Oscillation Damping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Control_Signal_TextBox;
        private System.Windows.Forms.Label Disturbance_Signal;
        private System.Windows.Forms.TextBox Disturbance_Signal_TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Analog_IN_0_TextBox;
        private System.Windows.Forms.TextBox Analog_IN_1_TextBox;
        private System.Windows.Forms.TextBox Position_Signal_TextBox;
        private System.Windows.Forms.TextBox Velocity_Signal_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Enable_checkBox;
        private System.Windows.Forms.ComboBox Lab_Selector_ComboBox;
        private System.Windows.Forms.Timer Timer;
    }
}

