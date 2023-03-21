namespace WFBuoi1
{
    partial class BaseCalculator
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
            this.soHang1 = new System.Windows.Forms.Label();
            this.soHang2 = new System.Windows.Forms.Label();
            this.str1 = new System.Windows.Forms.TextBox();
            this.str2 = new System.Windows.Forms.TextBox();
            this.reSult = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soHang1
            // 
            this.soHang1.AutoSize = true;
            this.soHang1.Location = new System.Drawing.Point(174, 45);
            this.soHang1.Name = "soHang1";
            this.soHang1.Size = new System.Drawing.Size(99, 16);
            this.soHang1.TabIndex = 0;
            this.soHang1.Text = "Số Hạng Thứ 1:";
            // 
            // soHang2
            // 
            this.soHang2.AutoSize = true;
            this.soHang2.Location = new System.Drawing.Point(174, 96);
            this.soHang2.Name = "soHang2";
            this.soHang2.Size = new System.Drawing.Size(99, 16);
            this.soHang2.TabIndex = 1;
            this.soHang2.Text = "Số Hạng Thứ 2:";
            // 
            // str1
            // 
            this.str1.Location = new System.Drawing.Point(363, 39);
            this.str1.Name = "str1";
            this.str1.Size = new System.Drawing.Size(205, 22);
            this.str1.TabIndex = 2;
            // 
            // str2
            // 
            this.str2.Location = new System.Drawing.Point(363, 96);
            this.str2.Name = "str2";
            this.str2.Size = new System.Drawing.Size(205, 22);
            this.str2.TabIndex = 3;
            // 
            // reSult
            // 
            this.reSult.AutoSize = true;
            this.reSult.Location = new System.Drawing.Point(174, 242);
            this.reSult.Name = "reSult";
            this.reSult.Size = new System.Drawing.Size(57, 16);
            this.reSult.TabIndex = 4;
            this.reSult.Text = "Kết Quả:";
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(363, 242);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(205, 22);
            this.str.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(177, 291);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(74, 28);
            this.sum.TabIndex = 6;
            this.sum.Text = "Tổng";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(363, 291);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(177, 331);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(74, 28);
            this.sub.TabIndex = 9;
            this.sub.Text = "Hiệu";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // BaseCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.str);
            this.Controls.Add(this.reSult);
            this.Controls.Add(this.str2);
            this.Controls.Add(this.str1);
            this.Controls.Add(this.soHang2);
            this.Controls.Add(this.soHang1);
            this.Name = "BaseCalculator";
            this.Text = "BaseCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soHang1;
        private System.Windows.Forms.Label soHang2;
        private System.Windows.Forms.TextBox str1;
        private System.Windows.Forms.TextBox str2;
        private System.Windows.Forms.Label reSult;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button sub;
    }
}