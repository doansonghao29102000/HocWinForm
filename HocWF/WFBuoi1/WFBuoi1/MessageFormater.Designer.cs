using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WFBuoi1
{
    partial class MessageFormater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageFormater));
            this.grB1 = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grB2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cBUnderline = new System.Windows.Forms.CheckBox();
            this.cBItalic = new System.Windows.Forms.CheckBox();
            this.cBBold = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.grB1.SuspendLayout();
            this.grB2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // grB1
            // 
            this.grB1.Controls.Add(this.radBlack);
            this.grB1.Controls.Add(this.radBlue);
            this.grB1.Controls.Add(this.radGreen);
            this.grB1.Controls.Add(this.radRed);
            this.grB1.Location = new System.Drawing.Point(105, 112);
            this.grB1.Name = "grB1";
            this.grB1.Size = new System.Drawing.Size(205, 153);
            this.grB1.TabIndex = 1;
            this.grB1.TabStop = false;
            this.grB1.Text = "color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(29, 111);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(62, 20);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "B&lack";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(29, 81);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(55, 20);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "&Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(29, 51);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(65, 20);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "&Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(29, 21);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(54, 20);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "&Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // grB2
            // 
            this.grB2.Controls.Add(this.richTextBox1);
            this.grB2.Controls.Add(this.cBUnderline);
            this.grB2.Controls.Add(this.cBItalic);
            this.grB2.Controls.Add(this.cBBold);
            this.grB2.Location = new System.Drawing.Point(426, 112);
            this.grB2.Name = "grB2";
            this.grB2.Size = new System.Drawing.Size(206, 153);
            this.grB2.TabIndex = 2;
            this.grB2.TabStop = false;
            this.grB2.Text = "Style";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(224, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(116, 131);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // cBUnderline
            // 
            this.cBUnderline.AutoSize = true;
            this.cBUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBUnderline.Location = new System.Drawing.Point(24, 98);
            this.cBUnderline.Name = "cBUnderline";
            this.cBUnderline.Size = new System.Drawing.Size(87, 20);
            this.cBUnderline.TabIndex = 2;
            this.cBUnderline.Text = "Underline";
            this.cBUnderline.UseVisualStyleBackColor = true;
            this.cBUnderline.CheckedChanged += new System.EventHandler(this.cBUnderline_CheckedChanged);
            // 
            // cBItalic
            // 
            this.cBItalic.AutoSize = true;
            this.cBItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBItalic.Location = new System.Drawing.Point(24, 65);
            this.cBItalic.Name = "cBItalic";
            this.cBItalic.Size = new System.Drawing.Size(56, 20);
            this.cBItalic.TabIndex = 1;
            this.cBItalic.Text = "&Italic";
            this.cBItalic.UseVisualStyleBackColor = true;
            this.cBItalic.CheckedChanged += new System.EventHandler(this.cBItalic_CheckedChanged);
            // 
            // cBBold
            // 
            this.cBBold.AutoSize = true;
            this.cBBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBold.Location = new System.Drawing.Point(24, 32);
            this.cBBold.Name = "cBBold";
            this.cBBold.Size = new System.Drawing.Size(61, 20);
            this.cBBold.TabIndex = 0;
            this.cBBold.Text = "B&old";
            this.cBBold.UseVisualStyleBackColor = true;
            this.cBBold.CheckedChanged += new System.EventHandler(this.cBBold_CheckedChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(650, 273);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 40);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(650, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(650, 351);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 40);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lbM
            // 
            this.lbM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbM.Location = new System.Drawing.Point(257, 295);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(299, 135);
            this.lbM.TabIndex = 7;
            this.lbM.Text = "hihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(105, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(125, 59);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(371, 22);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 22);
            this.txtName.TabIndex = 2;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbMessage.Location = new System.Drawing.Point(48, 65);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(64, 16);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Message";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbName.Location = new System.Drawing.Point(40, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Your name";
            // 
            // picBig
            // 
            this.picBig.Image = ((System.Drawing.Image)(resources.GetObject("picBig.Image")));
            this.picBig.Location = new System.Drawing.Point(27, 312);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(102, 94);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 9;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // picSmall
            // 
            this.picSmall.Image = ((System.Drawing.Image)(resources.GetObject("picSmall.Image")));
            this.picSmall.Location = new System.Drawing.Point(156, 320);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(83, 70);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 10;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // MessageFormater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.grB2);
            this.Controls.Add(this.grB1);
            this.Name = "MessageFormater";
            this.Text = "MessageFormater";
            this.Load += new System.EventHandler(this.MessageFormater_Load);
            this.grB1.ResumeLayout(false);
            this.grB1.PerformLayout();
            this.grB2.ResumeLayout(false);
            this.grB2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB1;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grB2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.CheckBox cBUnderline;
        private System.Windows.Forms.CheckBox cBItalic;
        private System.Windows.Forms.CheckBox cBBold;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}