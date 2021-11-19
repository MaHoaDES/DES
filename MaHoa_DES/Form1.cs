using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaHoa_DES
{
    public partial class Form1 : Form
    {
        C_MaHoaDES DES = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DES = new C_MaHoaDES(Directory.GetCurrentDirectory()+"\\DLL\\KhoiTao_DES", Directory.GetCurrentDirectory()+"\\DLL\\ASCtoNhiPhan");
            Readme(sender, e);
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            label3.Text = "Mã hóa";
            groupBox2.Text = "Kết Quả";
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {
                    txtBanMaHoa.Text = DES.DES(txtBanRo.Text, txtKhoa.Text);
                    txtKetQua.Text = C_MaHoaDES.thaoTac;
                }
                else
                    MessageBox.Show("Hãy nhập từ cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGiaiMa(object sender, EventArgs e)
        {
            txtBanRo.Text = txtBanMaHoa.Text;
            txtBanMaHoa.Text = "";
            label3.Text = "Giải mã";
            groupBox2.Text = "Kết Quả";
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {
                    txtBanMaHoa.Text = DES.DES_GiaiMa(txtBanRo.Text, txtKhoa.Text);
                    txtKetQua.Text = C_MaHoaDES.thaoTac;
                }
                else
                    MessageBox.Show("Hãy nhập từ cần giải mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfl = new SaveFileDialog();
            sfl.Filter = "TEXT|*.txt";
            if (sfl.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfl.FileName, txtKetQua.Text);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lập Trình Phần Mềm Mã Hóa Thuật Toán DES\t\n\tThực Hiện Bởi - Nhóm 06\n  1. 1921050351 - Lưu Gia Linh\n  2. 1921050394 - Phạm Thị Hồng Minh", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnXoa(object sender, EventArgs e)
        {
            txtBanRo.Text = "";
            txtKhoa.Text = "";
            txtBanMaHoa.Text = "";
            Form1_Load(sender, e);
        }

        private void Readme(object sender, EventArgs e)
        {
            groupBox2.Text = "Hướng dân";
            string instruct = "\t\t\t\t\t\t\t******************************\t\t\t\t\t\t\t\t" 
                                + "\t\t\t\t\t\tHƯỚNG DẪN SỬ DỤNG" 
                                + "\t\t\t\t\t\t\t\t\t\t\t\t       PHẦN MỀM MÃ HÓA VÀ GIẢI MÃ THUẬT TOÁN DES" 
                                + "\t\t\t\t\t\t\t\t\t\t\t\t\t******************************" 
                                + "\t\t\t\t\t\t\t\t\t\t\tĐược thực hiện bởi - Nhóm 06 : \t 1. 1921050351 - Lưu Gia Linh \n\t\t\t\t\t\t\t\t\t\t\t\t\t 2. 1921050394 - Phạm Thị Hồng Minh\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t"
                                + "\t\t\t\t\t\t\t\t\tBước 1 : Nhập bản rõ."
                                + "\t\t\t\t\t\t\t\t\t\t\t\t\t\tBước 2 : Nhập khóa ( 8 ký tự )"
                                + "\t\t\t\t\t\t\t\t\t\t\t\t\t\tBước 3 : Bấm nút 'Mã hóa'."
                                + "\t\t\t\t\t\t\t\t\t\t\t\t\t\tBước 4 : Sau khi mã hóa thành công bấm nút 'Giải mã' để giải mã.\t\t\t\t\t\t\t\t\t\t\t-------------------------------------------------------"
                                + "\t\t\t\t\t\t\t\t\t\t\t\tChú ý : Nếu bản rõ chưa đủ kí tự để chia thành các khổi 64 bit thì phần mềm tự thêm khoảng trắng vào cuối";
            txtKetQua.Text = instruct;
        }

        private void T(object sender, EventArgs e)
        {
            string temp;
            temp = txtBanRo.Text;
            txtBanRo.Text = txtBanMaHoa.Text;
            label3.Text = "Giải mã";
            groupBox2.Text = "Kết Quả";
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {
                    txtBanMaHoa.Text = DES.DES_GiaiMa(txtBanRo.Text, txtKhoa.Text);
                    txtKetQua.Text = C_MaHoaDES.thaoTac + "\n=> BẢN GIẢI MÃ CUỐI: " + temp;
                    txtBanMaHoa.Text = temp;
                }
                else
                    MessageBox.Show("Hãy nhập từ cần giải mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
