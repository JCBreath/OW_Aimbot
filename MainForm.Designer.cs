namespace ECS188
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ColorLabel = new System.Windows.Forms.Label();
            this.testBox = new System.Windows.Forms.CheckBox();
            this.EnbHdLckCheck = new System.Windows.Forms.CheckBox();
            this.capView = new System.Windows.Forms.PictureBox();
            this.OBSStatus = new System.Windows.Forms.Label();
            this.trackingSetting = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rectHtText = new System.Windows.Forms.TextBox();
            this.rectHtLabel = new System.Windows.Forms.Label();
            this.rectWdLabel = new System.Windows.Forms.Label();
            this.rectWdText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dectXText = new System.Windows.Forms.TextBox();
            this.dectYText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dynSpdCheck = new System.Windows.Forms.CheckBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.XSpeedText = new System.Windows.Forms.TextBox();
            this.sensiLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sensiText = new System.Windows.Forms.TextBox();
            this.YSpeedText = new System.Windows.Forms.TextBox();
            this.limitHtText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limitWdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.envGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.trigCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.capView)).BeginInit();
            this.trackingSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.envGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(505, 209);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(95, 13);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "NOT DETECTING";
            this.ColorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // testBox
            // 
            this.testBox.AutoSize = true;
            this.testBox.Location = new System.Drawing.Point(537, 88);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(99, 17);
            this.testBox.TabIndex = 2;
            this.testBox.Text = "DEBUG MODE";
            this.testBox.UseVisualStyleBackColor = true;
            this.testBox.CheckedChanged += new System.EventHandler(this.testBox_CheckedChanged);
            // 
            // EnbHdLckCheck
            // 
            this.EnbHdLckCheck.AutoSize = true;
            this.EnbHdLckCheck.Checked = true;
            this.EnbHdLckCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnbHdLckCheck.Location = new System.Drawing.Point(10, 19);
            this.EnbHdLckCheck.Name = "EnbHdLckCheck";
            this.EnbHdLckCheck.Size = new System.Drawing.Size(33, 17);
            this.EnbHdLckCheck.TabIndex = 4;
            this.EnbHdLckCheck.Text = "X";
            this.EnbHdLckCheck.UseVisualStyleBackColor = true;
            // 
            // capView
            // 
            this.capView.Location = new System.Drawing.Point(3, 225);
            this.capView.Name = "capView";
            this.capView.Size = new System.Drawing.Size(633, 280);
            this.capView.TabIndex = 5;
            this.capView.TabStop = false;
            // 
            // OBSStatus
            // 
            this.OBSStatus.AutoSize = true;
            this.OBSStatus.Location = new System.Drawing.Point(408, 165);
            this.OBSStatus.Name = "OBSStatus";
            this.OBSStatus.Size = new System.Drawing.Size(44, 13);
            this.OBSStatus.TabIndex = 7;
            this.OBSStatus.Text = "READY";
            // 
            // trackingSetting
            // 
            this.trackingSetting.Controls.Add(this.checkBox1);
            this.trackingSetting.Controls.Add(this.EnbHdLckCheck);
            this.trackingSetting.Location = new System.Drawing.Point(537, 12);
            this.trackingSetting.Name = "trackingSetting";
            this.trackingSetting.Size = new System.Drawing.Size(90, 70);
            this.trackingSetting.TabIndex = 8;
            this.trackingSetting.TabStop = false;
            this.trackingSetting.Text = "Axis Tracking";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Y";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rectHtText
            // 
            this.rectHtText.Location = new System.Drawing.Point(65, 55);
            this.rectHtText.Name = "rectHtText";
            this.rectHtText.Size = new System.Drawing.Size(46, 20);
            this.rectHtText.TabIndex = 9;
            this.rectHtText.Text = "100";
            // 
            // rectHtLabel
            // 
            this.rectHtLabel.AutoSize = true;
            this.rectHtLabel.Location = new System.Drawing.Point(18, 58);
            this.rectHtLabel.Name = "rectHtLabel";
            this.rectHtLabel.Size = new System.Drawing.Size(38, 13);
            this.rectHtLabel.TabIndex = 10;
            this.rectHtLabel.Text = "Height";
            // 
            // rectWdLabel
            // 
            this.rectWdLabel.AutoSize = true;
            this.rectWdLabel.Location = new System.Drawing.Point(18, 32);
            this.rectWdLabel.Name = "rectWdLabel";
            this.rectWdLabel.Size = new System.Drawing.Size(35, 13);
            this.rectWdLabel.TabIndex = 11;
            this.rectWdLabel.Text = "Width";
            // 
            // rectWdText
            // 
            this.rectWdText.Location = new System.Drawing.Point(65, 29);
            this.rectWdText.Name = "rectWdText";
            this.rectWdText.Size = new System.Drawing.Size(46, 20);
            this.rectWdText.TabIndex = 12;
            this.rectWdText.Text = "300";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rectHtLabel);
            this.groupBox1.Controls.Add(this.dectXText);
            this.groupBox1.Controls.Add(this.rectWdText);
            this.groupBox1.Controls.Add(this.dectYText);
            this.groupBox1.Controls.Add(this.rectHtText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rectWdLabel);
            this.groupBox1.Location = new System.Drawing.Point(408, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detect Box Setting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Y";
            // 
            // dectXText
            // 
            this.dectXText.Location = new System.Drawing.Point(65, 81);
            this.dectXText.Name = "dectXText";
            this.dectXText.Size = new System.Drawing.Size(46, 20);
            this.dectXText.TabIndex = 12;
            this.dectXText.Text = "960";
            // 
            // dectYText
            // 
            this.dectYText.Location = new System.Drawing.Point(65, 107);
            this.dectYText.Name = "dectYText";
            this.dectYText.Size = new System.Drawing.Size(46, 20);
            this.dectYText.TabIndex = 9;
            this.dectYText.Text = "520";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(9, 209);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(45, 13);
            this.viewLabel.TabIndex = 14;
            this.viewLabel.Text = "Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dynSpdCheck);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.XSpeedText);
            this.groupBox2.Controls.Add(this.sensiLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sensiText);
            this.groupBox2.Controls.Add(this.YSpeedText);
            this.groupBox2.Controls.Add(this.limitHtText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.limitWdText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 142);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "瞄 Setting";
            // 
            // dynSpdCheck
            // 
            this.dynSpdCheck.AutoSize = true;
            this.dynSpdCheck.Location = new System.Drawing.Point(119, 76);
            this.dynSpdCheck.Name = "dynSpdCheck";
            this.dynSpdCheck.Size = new System.Drawing.Size(101, 17);
            this.dynSpdCheck.TabIndex = 13;
            this.dynSpdCheck.Text = "Dynamic Speed";
            this.dynSpdCheck.UseVisualStyleBackColor = true;
            this.dynSpdCheck.CheckedChanged += new System.EventHandler(this.dynSpdCheck_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(119, 99);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "甩头";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "X Speed";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "粘身";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // XSpeedText
            // 
            this.XSpeedText.Location = new System.Drawing.Point(170, 23);
            this.XSpeedText.Name = "XSpeedText";
            this.XSpeedText.Size = new System.Drawing.Size(46, 20);
            this.XSpeedText.TabIndex = 9;
            this.XSpeedText.Text = "10";
            this.XSpeedText.TextChanged += new System.EventHandler(this.XSpeedText_TextChanged);
            // 
            // sensiLabel
            // 
            this.sensiLabel.AutoSize = true;
            this.sensiLabel.Location = new System.Drawing.Point(17, 76);
            this.sensiLabel.Name = "sensiLabel";
            this.sensiLabel.Size = new System.Drawing.Size(31, 13);
            this.sensiLabel.TabIndex = 10;
            this.sensiLabel.Text = "灵敏";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // sensiText
            // 
            this.sensiText.Location = new System.Drawing.Point(64, 73);
            this.sensiText.Name = "sensiText";
            this.sensiText.Size = new System.Drawing.Size(46, 20);
            this.sensiText.TabIndex = 9;
            this.sensiText.Text = "1000";
            this.sensiText.TextChanged += new System.EventHandler(this.sensiText_TextChanged);
            // 
            // YSpeedText
            // 
            this.YSpeedText.Location = new System.Drawing.Point(170, 49);
            this.YSpeedText.Name = "YSpeedText";
            this.YSpeedText.Size = new System.Drawing.Size(46, 20);
            this.YSpeedText.TabIndex = 12;
            this.YSpeedText.Text = "10";
            this.YSpeedText.TextChanged += new System.EventHandler(this.YSpeedText_TextChanged);
            // 
            // limitHtText
            // 
            this.limitHtText.Location = new System.Drawing.Point(64, 48);
            this.limitHtText.Name = "limitHtText";
            this.limitHtText.Size = new System.Drawing.Size(46, 20);
            this.limitHtText.TabIndex = 9;
            this.limitHtText.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y Speed";
            // 
            // limitWdText
            // 
            this.limitWdText.Location = new System.Drawing.Point(64, 23);
            this.limitWdText.Name = "limitWdText";
            this.limitWdText.Size = new System.Drawing.Size(46, 20);
            this.limitWdText.TabIndex = 12;
            this.limitWdText.Text = "120";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // envGroupBox
            // 
            this.envGroupBox.Controls.Add(this.radioButton3);
            this.envGroupBox.Controls.Add(this.radioButton2);
            this.envGroupBox.Controls.Add(this.radioButton1);
            this.envGroupBox.Location = new System.Drawing.Point(12, 12);
            this.envGroupBox.Name = "envGroupBox";
            this.envGroupBox.Size = new System.Drawing.Size(153, 142);
            this.envGroupBox.TabIndex = 17;
            this.envGroupBox.TabStop = false;
            this.envGroupBox.Text = "Environment";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "GOLD RUSH";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Deep Dark Fantasy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sci-Fi Bright";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(552, 160);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 18;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(327, 160);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 23);
            this.helpBtn.TabIndex = 19;
            this.helpBtn.Text = "帮助";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // trigCheck
            // 
            this.trigCheck.AutoSize = true;
            this.trigCheck.Location = new System.Drawing.Point(537, 112);
            this.trigCheck.Name = "trigCheck";
            this.trigCheck.Size = new System.Drawing.Size(59, 17);
            this.trigCheck.TabIndex = 20;
            this.trigCheck.Text = "Trigger";
            this.trigCheck.UseVisualStyleBackColor = true;
            this.trigCheck.CheckedChanged += new System.EventHandler(this.trigCheck_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 508);
            this.Controls.Add(this.trigCheck);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.envGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackingSetting);
            this.Controls.Add(this.OBSStatus);
            this.Controls.Add(this.capView);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.ColorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RivaTuner Statistics Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capView)).EndInit();
            this.trackingSetting.ResumeLayout(false);
            this.trackingSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.envGroupBox.ResumeLayout(false);
            this.envGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.CheckBox testBox;
        private System.Windows.Forms.CheckBox EnbHdLckCheck;
        private System.Windows.Forms.PictureBox capView;
        private System.Windows.Forms.Label OBSStatus;
        private System.Windows.Forms.GroupBox trackingSetting;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox rectHtText;
        private System.Windows.Forms.Label rectHtLabel;
        private System.Windows.Forms.Label rectWdLabel;
        private System.Windows.Forms.TextBox rectWdText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox limitHtText;
        private System.Windows.Forms.TextBox limitWdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox XSpeedText;
        private System.Windows.Forms.TextBox YSpeedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox envGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label sensiLabel;
        private System.Windows.Forms.TextBox sensiText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dectXText;
        private System.Windows.Forms.TextBox dectYText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.CheckBox dynSpdCheck;
        private System.Windows.Forms.CheckBox trigCheck;
    }
}

