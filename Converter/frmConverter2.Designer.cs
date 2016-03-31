namespace Converter
{
    partial class frmConverter2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBitBu2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBitBu1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBitBuDau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBitBu2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBitBu1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBitBuDau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output - Các dãy bit sau khi dịch sẽ hiển thị ở đây";
            // 
            // txtBitBu2
            // 
            this.txtBitBu2.Location = new System.Drawing.Point(93, 81);
            this.txtBitBu2.Name = "txtBitBu2";
            this.txtBitBu2.ReadOnly = true;
            this.txtBitBu2.Size = new System.Drawing.Size(162, 20);
            this.txtBitBu2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuẩn  bù 2:";
            // 
            // txtBitBu1
            // 
            this.txtBitBu1.Location = new System.Drawing.Point(93, 55);
            this.txtBitBu1.Name = "txtBitBu1";
            this.txtBitBu1.ReadOnly = true;
            this.txtBitBu1.Size = new System.Drawing.Size(162, 20);
            this.txtBitBu1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuẩn  bù 1:";
            // 
            // txtBitBuDau
            // 
            this.txtBitBuDau.Location = new System.Drawing.Point(93, 29);
            this.txtBitBuDau.Name = "txtBitBuDau";
            this.txtBitBuDau.ReadOnly = true;
            this.txtBitBuDau.Size = new System.Drawing.Size(162, 20);
            this.txtBitBuDau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuẩn  bù dấu:";
            // 
            // Input
            // 
            this.Input.Controls.Add(this.txtNum);
            this.Input.Location = new System.Drawing.Point(7, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(270, 70);
            this.Input.TabIndex = 5;
            this.Input.TabStop = false;
            this.Input.Text = "Input - Nhập số nguyên cần dịch ở đây";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(6, 29);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(256, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(100, 232);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(80, 31);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConverter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmConverter2";
            this.Text = "KTMT Cheat Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBitBu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBitBu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBitBuDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnConvert;
    }
}