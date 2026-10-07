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

                    dataGridView1.DataSource = dt;
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
       
        
    }
}