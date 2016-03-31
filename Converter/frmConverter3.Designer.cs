namespace Converter
{
    partial class frmConverter3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtFrac = new System.Windows.Forms.TextBox();
            this.txtExpo = new System.Windows.Forms.TextBox();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.txtSingle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBit88 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.btnConvertReal = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtS);
            this.groupBox3.Controls.Add(this.txtFrac);
            this.groupBox3.Controls.Add(this.txtExpo);
            this.groupBox3.Controls.Add(this.txtDouble);
            this.groupBox3.Controls.Add(this.txtSingle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBit88);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 337);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output - Các dãy bit sau khi dịch sẽ hiển thị ở đây";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(55, 123);
            this.txtS.Name = "txtS";
            this.txtS.ReadOnly = true;
            this.txtS.Size = new System.Drawing.Size(202, 20);
            this.txtS.TabIndex = 1;
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(55, 172);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.ReadOnly = true;
            this.txtFrac.Size = new System.Drawing.Size(202, 20);
            this.txtFrac.TabIndex = 1;
            // 
            // txtExpo
            // 
            this.txtExpo.Location = new System.Drawing.Point(55, 148);
            this.txtExpo.Name = "txtExpo";
            this.txtExpo.ReadOnly = true;
            this.txtExpo.Size = new System.Drawing.Size(202, 20);
            this.txtExpo.TabIndex = 1;
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(9, 271);
            this.txtDouble.Multiline = true;
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.ReadOnly = true;
            this.txtDouble.Size = new System.Drawing.Size(248, 60);
            this.txtDouble.TabIndex = 1;
            this.txtDouble.TextChanged += new System.EventHandler(this.txtDouble_TextChanged);
            // 
            // txtSingle
            // 
            this.txtSingle.Location = new System.Drawing.Point(9, 221);
            this.txtSingle.Name = "txtSingle";
            this.txtSingle.ReadOnly = true;
            this.txtSingle.Size = new System.Drawing.Size(248, 20);
            this.txtSingle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fraction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Biểu diễn phẩy động double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Biểu diễn phẩy động single";
            // 
            // txtBit88
            // 
            this.txtBit88.Location = new System.Drawing.Point(120, 71);
            this.txtBit88.Name = "txtBit88";
            this.txtBit88.ReadOnly = true;
            this.txtBit88.Size = new System.Drawing.Size(137, 20);
            this.txtBit88.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Biểu diễn 16bit 8/8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFloat);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input - Nhập số thực cần dịch ở đây";
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(6, 29);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(251, 20);
            this.txtFloat.TabIndex = 1;
            this.txtFloat.Text = "64.275";
            // 
            // btnConvertReal
            // 
            this.btnConvertReal.Location = new System.Drawing.Point(102, 435);
            this.btnConvertReal.Name = "btnConvertReal";
            this.btnConvertReal.Size = new System.Drawing.Size(80, 31);
            this.btnConvertReal.TabIndex = 7;
            this.btnConvertReal.Text = "Convert";
            this.btnConvertReal.UseVisualStyleBackColor = true;
            this.btnConvertReal.Click += new System.EventHandler(this.btnConvertReal_Click);
            // 
            // frmConverter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConvertReal);
            this.Name = "frmConverter3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTMT Cheat Tool";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSingle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBit88;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.Button btnConvertReal;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtFrac;
        private System.Windows.Forms.TextBox txtExpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDouble;
        private System.Windows.Forms.Label label8;

    }
}