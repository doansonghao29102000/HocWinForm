namespace WFBuoi1
{
    partial class HoTen
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
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblHoVaTen.Location = new System.Drawing.Point(94, 49);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(590, 78);
            this.lblHoVaTen.TabIndex = 0;
            // 
            // lblHoLot
            // 
            this.lblHoLot.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHoLot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoLot.Location = new System.Drawing.Point(97, 174);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(247, 30);
            this.lblHoLot.TabIndex = 1;
            this.lblHoLot.Text = "Họ lót";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoLot.Location = new System.Drawing.Point(369, 174);
            this.txtHoLot.Multiline = true;
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(315, 30);
            this.txtHoLot.TabIndex = 3;
            this.txtHoLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoLot_KeyDown);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(369, 230);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(315, 30);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnHoLot
            // 
            this.btnHoLot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHoLot.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoLot.Location = new System.Drawing.Point(213, 322);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(105, 43);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "Họ lót";
            this.btnHoLot.UseVisualStyleBackColor = false;
            this.btnHoLot.TextChanged += new System.EventHandler(this.btnChagedHoLot);
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(369, 322);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(105, 43);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHoVaTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoVaTen.Location = new System.Drawing.Point(517, 322);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(105, 43);
            this.btnHoVaTen.TabIndex = 7;
            this.btnHoVaTen.Text = "Họ và Tên";
            this.btnHoVaTen.UseVisualStyleBackColor = false;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(369, 395);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(105, 43);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(97, 230);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(247, 30);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên";
            // 
            // HoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.lblHoVaTen);
            this.Name = "HoTen";
            this.Text = "HoTen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label lblTen;
    }
}

