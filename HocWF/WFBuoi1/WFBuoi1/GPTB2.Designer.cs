namespace WFBuoi1
{
    partial class GPTB2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGPT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.lbx2 = new System.Windows.Forms.Label();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.lbx1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnGPT
            // 
            this.btnGPT.Location = new System.Drawing.Point(118, 382);
            this.btnGPT.Name = "btnGPT";
            this.btnGPT.Size = new System.Drawing.Size(179, 48);
            this.btnGPT.TabIndex = 16;
            this.btnGPT.Text = "Giải PT";
            this.btnGPT.UseVisualStyleBackColor = true;
            this.btnGPT.Click += new System.EventHandler(this.btnGPT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNo2);
            this.groupBox2.Controls.Add(this.lbx2);
            this.groupBox2.Controls.Add(this.txtNo1);
            this.groupBox2.Controls.Add(this.lbx1);
            this.groupBox2.Location = new System.Drawing.Point(94, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 138);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtNo2
            // 
            this.txtNo2.Enabled = false;
            this.txtNo2.Location = new System.Drawing.Point(132, 89);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.ReadOnly = true;
            this.txtNo2.Size = new System.Drawing.Size(491, 22);
            this.txtNo2.TabIndex = 9;
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Location = new System.Drawing.Point(34, 87);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(70, 16);
            this.lbx2.TabIndex = 8;
            this.lbx2.Text = "Nghiệm x2";
            // 
            // txtNo1
            // 
            this.txtNo1.Enabled = false;
            this.txtNo1.Location = new System.Drawing.Point(132, 40);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.ReadOnly = true;
            this.txtNo1.Size = new System.Drawing.Size(491, 22);
            this.txtNo1.TabIndex = 7;
            // 
            // lbx1
            // 
            this.lbx1.AutoSize = true;
            this.lbx1.Location = new System.Drawing.Point(34, 40);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(70, 16);
            this.lbx1.TabIndex = 6;
            this.lbx1.Text = "Nghiệm x1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(114, 136);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(363, 22);
            this.txtC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hệ số c";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(114, 84);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(363, 22);
            this.txtB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(114, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(363, 22);
            this.txtA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a";
            // 
            // GPTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGPT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GPTB2";
            this.Text = "GPTB2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGPT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.Label lbx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
    }
}