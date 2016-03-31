namespace Converter
{
    partial class frmMain
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
            this.btnMore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoubleToBit = new System.Windows.Forms.Button();
            this.btnDecToBit = new System.Windows.Forms.Button();
            this.btnBitToDouble = new System.Windows.Forms.Button();
            this.btnBitToDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMore);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDoubleToBit);
            this.groupBox1.Controls.Add(this.btnDecToBit);
            this.groupBox1.Controls.Add(this.btnBitToDouble);
            this.groupBox1.Controls.Add(this.btnBitToDec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(233, 121);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(100, 72);
            this.btnMore.TabIndex = 0;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tính giá trị của Dãy Bit dấu phẩy động";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnfrm5_Click);
            // 
            // btnDoubleToBit
            // 
            this.btnDoubleToBit.Location = new System.Drawing.Point(127, 121);
            this.btnDoubleToBit.Name = "btnDoubleToBit";
            this.btnDoubleToBit.Size = new System.Drawing.Size(100, 72);
            this.btnDoubleToBit.TabIndex = 0;
            this.btnDoubleToBit.Text = "Chuyển đổi số Thực sang dãy Bit";
            this.btnDoubleToBit.UseVisualStyleBackColor = true;
            this.btnDoubleToBit.Click += new System.EventHandler(this.btnDoubleToBit_Click);
            // 
            // btnDecToBit
            // 
            this.btnDecToBit.Location = new System.Drawing.Point(21, 121);
            this.btnDecToBit.Name = "btnDecToBit";
            this.btnDecToBit.Size = new System.Drawing.Size(100, 72);
            this.btnDecToBit.TabIndex = 0;
            this.btnDecToBit.Text = "Chuyển đổi số Nguyên sang dãy Bit";
            this.btnDecToBit.UseVisualStyleBackColor = true;
            this.btnDecToBit.Click += new System.EventHandler(this.btnDecToBit_Click);
            // 
            // btnBitToDouble
            // 
            this.btnBitToDouble.Location = new System.Drawing.Point(127, 43);
            this.btnBitToDouble.Name = "btnBitToDouble";
            this.btnBitToDouble.Size = new System.Drawing.Size(100, 72);
            this.btnBitToDouble.TabIndex = 0;
            this.btnBitToDouble.Text = "Tính giá trị của Dãy Bit dấu phẩy tĩnh";
            this.btnBitToDouble.UseVisualStyleBackColor = true;
            this.btnBitToDouble.Click += new System.EventHandler(this.btnBitToDouble_Click);
            // 
            // btnBitToDec
            // 
            this.btnBitToDec.Location = new System.Drawing.Point(21, 43);
            this.btnBitToDec.Name = "btnBitToDec";
            this.btnBitToDec.Size = new System.Drawing.Size(100, 72);
            this.btnBitToDec.TabIndex = 0;
            this.btnBitToDec.Text = "Chuyển đổi dãy Bit sang số Nguyên";
            this.btnBitToDec.UseVisualStyleBackColor = true;
            this.btnBitToDec.Click += new System.EventHandler(this.btnBitToDec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(190, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mr.Jris";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(174, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "®";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 428);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "KTMT Cheat Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoubleToBit;
        private System.Windows.Forms.Button btnDecToBit;
        private System.Windows.Forms.Button btnBitToDouble;
        private System.Windows.Forms.Button btnBitToDec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label3;


    }
}