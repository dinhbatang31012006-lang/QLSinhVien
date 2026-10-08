using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // Hoặc Microsoft.Data.SqlClient tùy thư viện bạn đã cài

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối CSDL của bạn
        string connectionString = @"Data Source=TANGDZVL\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form mở lên
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataSinhVien();
        }

        // Hàm đọc dữ liệu từ bảng Sinhvien
        private void LoadDataSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Masv, Tensv, Cccd, Gioitinh, Ngaysinh, Malop FROM Sinhvien";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            frmSinhvien frm = new frmSinhvien();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frm);

            frm.Show();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Bạn có chắc chắn muốn đăng xuất không?",
         "Xác nhận đăng xuất",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}