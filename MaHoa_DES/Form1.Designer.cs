namespace MaHoa_DES
{
    partial class Form1
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
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.txtBanMaHoa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBanRo
            // 
            this.txtBanRo.Location = new System.Drawing.Point(65, 34);
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(197, 20);
            this.txtBanRo.TabIndex = 0;
            // 
            // txtBanMaHoa
            // 
            this.txtBanMaHoa.Location = new System.Drawing.Point(65, 104);
            this.txtBanMaHoa.Name = "txtBanMaHoa";
            this.txtBanMaHoa.Size = new System.Drawing.Size(197, 20);
            this.txtBanMaHoa.TabIndex = 2;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(52, 141);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 67);
            this.btnMaHoa.TabIndex = 4;
            this.btnMaHoa.Text = "Mã Hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(65, 68);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(197, 20);
            this.txtKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khóa K";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bản rõ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã hóa";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Location = new System.Drawing.Point(3, 16);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(761, 234);
            this.txtKetQua.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXuatFile);
            this.groupBox1.Controls.Add(this.btnThongTin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBanRo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtBanMaHoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMaHoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Giải Mã";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.T);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(20, 214);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 23);
            this.btnXuatFile.TabIndex = 8;
            this.btnXuatFile.Text = "Xuất ra file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Location = new System.Drawing.Point(187, 214);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(75, 23);
            this.btnThongTin.TabIndex = 8;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(286, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 253);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mã Hóa - Giải Mã DES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.TextBox txtBanMaHoa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

