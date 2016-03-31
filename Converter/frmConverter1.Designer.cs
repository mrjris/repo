namespace Converter
{
    partial class frmConverter1
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(103, 214);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(80, 31);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(6, 29);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(256, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "10000001";
            // 
            // Input
            // 
            this.Input.Controls.Add(this.txtNum);
            this.Input.Location = new System.Drawing.Point(10, 9);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(270, 70);
            this.Input.TabIndex = 2;
            this.Input.TabStop = false;
            this.Input.Text = "Input - Nhập dãy bit muốn dịch";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtResult2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResult1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output - Kết quả sẽ hiển thị ở đây";
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(93, 81);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.ReadOnly = true;
            this.txtResult3.Size = new System.Drawing.Size(162, 20);
            this.txtResult3.TabIndex = 1;
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
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(93, 55);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(162, 20);
            this.txtResult2.TabIndex = 1;
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
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(93, 29);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(162, 20);
            this.txtResult1.TabIndex = 1;
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
            // frmConverter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmConverter1";
            this.Text = "KTMT Converter Bit To Dec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.Label label2;
    }
}

