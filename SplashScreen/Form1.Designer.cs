namespace SplashScreen
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLine1 = new System.Windows.Forms.TextBox();
            this.tbLine2 = new System.Windows.Forms.TextBox();
            this.tbLine3 = new System.Windows.Forms.TextBox();
            this.tbLine4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.tbContrast = new System.Windows.Forms.TextBox();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backlightOn = new System.Windows.Forms.RadioButton();
            this.backlightOff = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(36, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(123, 21);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(123, 171);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Line 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Line 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Line 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Line 4:";
            // 
            // tbLine1
            // 
            this.tbLine1.Location = new System.Drawing.Point(78, 66);
            this.tbLine1.MaxLength = 20;
            this.tbLine1.Name = "tbLine1";
            this.tbLine1.Size = new System.Drawing.Size(120, 20);
            this.tbLine1.TabIndex = 8;
            // 
            // tbLine2
            // 
            this.tbLine2.Location = new System.Drawing.Point(79, 93);
            this.tbLine2.MaxLength = 20;
            this.tbLine2.Name = "tbLine2";
            this.tbLine2.Size = new System.Drawing.Size(119, 20);
            this.tbLine2.TabIndex = 9;
            // 
            // tbLine3
            // 
            this.tbLine3.Location = new System.Drawing.Point(79, 118);
            this.tbLine3.MaxLength = 20;
            this.tbLine3.Name = "tbLine3";
            this.tbLine3.Size = new System.Drawing.Size(119, 20);
            this.tbLine3.TabIndex = 10;
            // 
            // tbLine4
            // 
            this.tbLine4.Location = new System.Drawing.Point(79, 145);
            this.tbLine4.MaxLength = 20;
            this.tbLine4.Name = "tbLine4";
            this.tbLine4.Size = new System.Drawing.Size(119, 20);
            this.tbLine4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Brightness [0-255]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contrast [0-255]";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(340, 90);
            this.tbBrightness.MaxLength = 3;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(39, 20);
            this.tbBrightness.TabIndex = 17;
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(340, 117);
            this.tbContrast.MaxLength = 3;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(39, 20);
            this.tbContrast.TabIndex = 18;
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(386, 87);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(37, 23);
            this.btnBrightness.TabIndex = 19;
            this.btnBrightness.Text = "Set";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.Location = new System.Drawing.Point(386, 117);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(37, 23);
            this.btnContrast.TabIndex = 20;
            this.btnContrast.Text = "Set";
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Backlight";
            // 
            // backlightOn
            // 
            this.backlightOn.AutoSize = true;
            this.backlightOn.Location = new System.Drawing.Point(340, 66);
            this.backlightOn.Name = "backlightOn";
            this.backlightOn.Size = new System.Drawing.Size(39, 17);
            this.backlightOn.TabIndex = 22;
            this.backlightOn.TabStop = true;
            this.backlightOn.Text = "On";
            this.backlightOn.UseVisualStyleBackColor = true;
            // 
            // backlightOff
            // 
            this.backlightOff.AutoSize = true;
            this.backlightOff.Location = new System.Drawing.Point(386, 66);
            this.backlightOff.Name = "backlightOff";
            this.backlightOff.Size = new System.Drawing.Size(39, 17);
            this.backlightOff.TabIndex = 23;
            this.backlightOff.TabStop = true;
            this.backlightOff.Text = "Off";
            this.backlightOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 229);
            this.Controls.Add(this.backlightOff);
            this.Controls.Add(this.backlightOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLine4);
            this.Controls.Add(this.tbLine3);
            this.Controls.Add(this.tbLine2);
            this.Controls.Add(this.tbLine1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Splash Screen Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLine1;
        private System.Windows.Forms.TextBox tbLine2;
        private System.Windows.Forms.TextBox tbLine3;
        private System.Windows.Forms.TextBox tbLine4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBrightness;
        private System.Windows.Forms.TextBox tbContrast;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton backlightOn;
        private System.Windows.Forms.RadioButton backlightOff;
    }
}

