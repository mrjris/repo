namespace Converter
{
    partial class frmConverter5
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpoString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtExpo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMuThuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(545, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "11001001111000000000000000000000";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(239, 243);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 193);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(545, 20);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "S =";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(93, 68);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(221, 20);
            this.txtS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expo String =";
            // 
            // txtExpoString
            // 
            this.txtExpoString.Location = new System.Drawing.Point(93, 94);
            this.txtExpoString.Name = "txtExpoString";
            this.txtExpoString.Size = new System.Drawing.Size(142, 20);
            this.txtExpoString.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frac =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(93, 146);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(221, 20);
            this.txtFrac.TabIndex = 3;
            this.txtFrac.TextChanged += new System.EventHandler(this.txtFrac_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(93, 42);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(221, 20);
            this.txtLength.TabIndex = 3;
            this.txtLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtExpo
            // 
            this.txtExpo.Location = new System.Drawing.Point(241, 94);
            this.txtExpo.Name = "txtExpo";
            this.txtExpo.Size = new System.Drawing.Size(73, 20);
            this.txtExpo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mũ thực =";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMuThuc
            // 
            this.txtMuThuc.Location = new System.Drawing.Point(93, 120);
            this.txtMuThuc.Name = "txtMuThuc";
            this.txtMuThuc.Size = new System.Drawing.Size(221, 20);
            this.txtMuThuc.TabIndex = 3;
            this.txtMuThuc.TextChanged += new System.EventHandler(this.txtFrac_TextChanged);
            // 
            // frmConverter5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 274);
            this.Controls.Add(this.txtMuThuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExpo);
            this.Controls.Add(this.txtExpoString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum);
            this.Name = "frmConverter5";
            this.Text = "frmConverter5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpoString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtExpo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMuThuc;
    }
}