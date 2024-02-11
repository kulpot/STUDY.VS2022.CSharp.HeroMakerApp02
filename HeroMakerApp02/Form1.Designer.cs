namespace HeroMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_energy = new System.Windows.Forms.CheckBox();
            this.chk_luck = new System.Windows.Forms.CheckBox();
            this.chk_fart = new System.Windows.Forms.CheckBox();
            this.chk_water_breath = new System.Windows.Forms.CheckBox();
            this.chk_timecontrol = new System.Windows.Forms.CheckBox();
            this.chk_invisible = new System.Windows.Forms.CheckBox();
            this.chk_xray = new System.Windows.Forms.CheckBox();
            this.chk_fly = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero\'s Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(86, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(226, 20);
            this.txt_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.chk_energy);
            this.groupBox1.Controls.Add(this.chk_luck);
            this.groupBox1.Controls.Add(this.chk_fart);
            this.groupBox1.Controls.Add(this.chk_water_breath);
            this.groupBox1.Controls.Add(this.chk_timecontrol);
            this.groupBox1.Controls.Add(this.chk_invisible);
            this.groupBox1.Controls.Add(this.chk_xray);
            this.groupBox1.Controls.Add(this.chk_fly);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilities";
            // 
            // chk_energy
            // 
            this.chk_energy.AutoSize = true;
            this.chk_energy.Location = new System.Drawing.Point(6, 97);
            this.chk_energy.Name = "chk_energy";
            this.chk_energy.Size = new System.Drawing.Size(95, 17);
            this.chk_energy.TabIndex = 4;
            this.chk_energy.Text = "Absorb Energy";
            this.chk_energy.UseVisualStyleBackColor = true;
            // 
            // chk_luck
            // 
            this.chk_luck.AutoSize = true;
            this.chk_luck.Location = new System.Drawing.Point(126, 28);
            this.chk_luck.Name = "chk_luck";
            this.chk_luck.Size = new System.Drawing.Size(91, 17);
            this.chk_luck.TabIndex = 7;
            this.chk_luck.Text = "Extreme Luck";
            this.chk_luck.UseVisualStyleBackColor = true;
            // 
            // chk_fart
            // 
            this.chk_fart.AutoSize = true;
            this.chk_fart.Location = new System.Drawing.Point(126, 51);
            this.chk_fart.Name = "chk_fart";
            this.chk_fart.Size = new System.Drawing.Size(97, 17);
            this.chk_fart.TabIndex = 6;
            this.chk_fart.Text = "Explosive Farts";
            this.chk_fart.UseVisualStyleBackColor = true;
            // 
            // chk_water_breath
            // 
            this.chk_water_breath.AutoSize = true;
            this.chk_water_breath.Location = new System.Drawing.Point(126, 74);
            this.chk_water_breath.Name = "chk_water_breath";
            this.chk_water_breath.Size = new System.Drawing.Size(103, 17);
            this.chk_water_breath.TabIndex = 5;
            this.chk_water_breath.Text = "Water Breathing";
            this.chk_water_breath.UseVisualStyleBackColor = true;
            // 
            // chk_timecontrol
            // 
            this.chk_timecontrol.AutoSize = true;
            this.chk_timecontrol.Location = new System.Drawing.Point(126, 97);
            this.chk_timecontrol.Name = "chk_timecontrol";
            this.chk_timecontrol.Size = new System.Drawing.Size(85, 17);
            this.chk_timecontrol.TabIndex = 4;
            this.chk_timecontrol.Text = "Time Control";
            this.chk_timecontrol.UseVisualStyleBackColor = true;
            // 
            // chk_invisible
            // 
            this.chk_invisible.AutoSize = true;
            this.chk_invisible.Location = new System.Drawing.Point(6, 74);
            this.chk_invisible.Name = "chk_invisible";
            this.chk_invisible.Size = new System.Drawing.Size(70, 17);
            this.chk_invisible.TabIndex = 2;
            this.chk_invisible.Text = "Invisibility";
            this.chk_invisible.UseVisualStyleBackColor = true;
            // 
            // chk_xray
            // 
            this.chk_xray.AutoSize = true;
            this.chk_xray.Location = new System.Drawing.Point(6, 51);
            this.chk_xray.Name = "chk_xray";
            this.chk_xray.Size = new System.Drawing.Size(81, 17);
            this.chk_xray.TabIndex = 1;
            this.chk_xray.Text = "xRay Vision";
            this.chk_xray.UseVisualStyleBackColor = true;
            // 
            // chk_fly
            // 
            this.chk_fly.AutoSize = true;
            this.chk_fly.Location = new System.Drawing.Point(6, 28);
            this.chk_fly.Name = "chk_fly";
            this.chk_fly.Size = new System.Drawing.Size(39, 17);
            this.chk_fly.TabIndex = 0;
            this.chk_fly.Text = "Fly";
            this.chk_fly.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(690, 405);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Hero";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Office Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_xray;
        private System.Windows.Forms.CheckBox chk_fly;
        private System.Windows.Forms.CheckBox chk_invisible;
        private System.Windows.Forms.CheckBox chk_luck;
        private System.Windows.Forms.CheckBox chk_fart;
        private System.Windows.Forms.CheckBox chk_water_breath;
        private System.Windows.Forms.CheckBox chk_timecontrol;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox chk_energy;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}

