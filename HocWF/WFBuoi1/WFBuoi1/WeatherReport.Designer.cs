namespace WFBuoi1
{
    partial class Weather_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather_Report));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdB1 = new System.Windows.Forms.RadioButton();
            this.rdB4 = new System.Windows.Forms.RadioButton();
            this.rdB3 = new System.Windows.Forms.RadioButton();
            this.rdB2 = new System.Windows.Forms.RadioButton();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(74, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name here";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(284, 54);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(446, 34);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdB1);
            this.groupBox1.Controls.Add(this.rdB4);
            this.groupBox1.Controls.Add(this.rdB3);
            this.groupBox1.Controls.Add(this.rdB2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(78, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdB1
            // 
            this.rdB1.AutoSize = true;
            this.rdB1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rdB1.Location = new System.Drawing.Point(29, 34);
            this.rdB1.Name = "rdB1";
            this.rdB1.Size = new System.Drawing.Size(87, 26);
            this.rdB1.TabIndex = 4;
            this.rdB1.TabStop = true;
            this.rdB1.Text = "&Cloudy";
            this.rdB1.UseVisualStyleBackColor = true;
            this.rdB1.CheckedChanged += new System.EventHandler(this.rdB1_CheckedChanged);
            // 
            // rdB4
            // 
            this.rdB4.AutoSize = true;
            this.rdB4.ForeColor = System.Drawing.Color.Crimson;
            this.rdB4.Location = new System.Drawing.Point(29, 118);
            this.rdB4.Name = "rdB4";
            this.rdB4.Size = new System.Drawing.Size(82, 26);
            this.rdB4.TabIndex = 3;
            this.rdB4.TabStop = true;
            this.rdB4.Text = "&Sunny";
            this.rdB4.UseVisualStyleBackColor = true;
            this.rdB4.CheckedChanged += new System.EventHandler(this.rdB4_CheckedChanged);
            // 
            // rdB3
            // 
            this.rdB3.AutoSize = true;
            this.rdB3.ForeColor = System.Drawing.Color.Blue;
            this.rdB3.Location = new System.Drawing.Point(29, 90);
            this.rdB3.Name = "rdB3";
            this.rdB3.Size = new System.Drawing.Size(79, 26);
            this.rdB3.TabIndex = 2;
            this.rdB3.TabStop = true;
            this.rdB3.Text = "&Slowy";
            this.rdB3.UseVisualStyleBackColor = true;
            this.rdB3.CheckedChanged += new System.EventHandler(this.rdB3_CheckedChanged);
            // 
            // rdB2
            // 
            this.rdB2.AutoSize = true;
            this.rdB2.ForeColor = System.Drawing.Color.DeepPink;
            this.rdB2.Location = new System.Drawing.Point(29, 62);
            this.rdB2.Name = "rdB2";
            this.rdB2.Size = new System.Drawing.Size(77, 26);
            this.rdB2.TabIndex = 1;
            this.rdB2.TabStop = true;
            this.rdB2.Text = "&Rainy";
            this.rdB2.UseVisualStyleBackColor = true;
            this.rdB2.CheckedChanged += new System.EventHandler(this.rdB2_CheckedChanged);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(378, 132);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(121, 67);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(551, 132);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(121, 67);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(378, 230);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(121, 67);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(551, 232);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(121, 67);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 7;
            this.pic4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(628, 327);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 37);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(628, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDisplay.Location = new System.Drawing.Point(75, 327);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(529, 96);
            this.lblDisplay.TabIndex = 11;
            // 
            // Weather_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Weather_Report";
            this.Text = "Weather_Report";
            this.Load += new System.EventHandler(this.Weather_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdB1;
        private System.Windows.Forms.RadioButton rdB4;
        private System.Windows.Forms.RadioButton rdB3;
        private System.Windows.Forms.RadioButton rdB2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplay;
    }
}