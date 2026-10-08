using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
            // Gắn sự kiện
            this.Load += frmSinhvien_Load;
            dgvSinhvien.CellClick += dgvSinhvien_CellClick;
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            // Load giới tính
            cboGioitinh.Items.Clear();
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            cboGioitinh.SelectedIndex = 0;

            // Load mã lớp
            LoadMaLop();

            // Load danh sách sinh viên
            LoadSinhVien();

            // Thiết lập DataGridView
            CaiDatDataGridView();
        }
        private void LoadSinhVien()
        {
            try
            {
                using (SqlConnection conn = ConnectDB.GetConnection())
                {
                    string sql = @"
                        SELECT 
                            Masv,
                            Tensv,
                            Cccd,
                            Gioitinh,
                            Ngaysinh,
                            Malop
                        FROM Sinhvien";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvSinhvien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách sinh viên!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // 3. LOAD MÃ LỚP
        // =====================================================
        private void LoadMaLop()
        {
            try
            {
                using (SqlConnection conn = ConnectDB.GetConnection())
                {
                    string sql = "SELECT Malop FROM Lop";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboMalop.DataSource = dt;
                    cboMalop.DisplayMember = "Malop";
                    cboMalop.ValueMember = "Malop";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách lớp!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // 4. CÀI ĐẶT DATAGRIDVIEW
        // =====================================================
        private void CaiDatDataGridView()
        {
            if (dgvSinhvien.Columns.Count == 0)
                return;

            // Đổi tên tiêu đề
            if (dgvSinhvien.Columns["Masv"] != null)
                dgvSinhvien.Columns["Masv"].HeaderText = "Mã SV";

            if (dgvSinhvien.Columns["Tensv"] != null)
                dgvSinhvien.Columns["Tensv"].HeaderText = "Tên sinh viên";

            if (dgvSinhvien.Columns["Cccd"] != null)
                dgvSinhvien.Columns["Cccd"].HeaderText = "CCCD";

            if (dgvSinhvien.Columns["Gioitinh"] != null)
                dgvSinhvien.Columns["Gioitinh"].HeaderText = "Giới tính";

            if (dgvSinhvien.Columns["Ngaysinh"] != null)
                dgvSinhvien.Columns["Ngaysinh"].HeaderText = "Ngày sinh";

            if (dgvSinhvien.Columns["Malop"] != null)
                dgvSinhvien.Columns["Malop"].HeaderText = "Mã lớp";
        }
        private bool KiemTraDuLieu()
        {
            if (txtMasv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMasv.Focus();
                return false;
            }

            if (txtTensv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
                txtTensv.Focus();
                return false;
            }

            if (txtCCCD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD!");
                txtCCCD.Focus();
                return false;
            }

            if (txtCCCD.Text.Trim().Length != 10)
            {
                MessageBox.Show("CCCD phải có đúng 10 ký tự!");
                txtCCCD.Focus();
                return false;
            }

            if (cboMalop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã lớp!");
                cboMalop.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (!KiemTraDuLieu())
                return;

            try
            {
                using (SqlConnection conn = ConnectDB.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Sinhvien
                        (
                            Masv,
                            Tensv,
                            Cccd,
                            Gioitinh,
                            Ngaysinh,Malop
                        )
                        VALUES
                        (
                            @Masv,
                            @Tensv,
                            @Cccd,
                            @Gioitinh,
                            @Ngaysinh,
                            @Malop
                        )";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Masv",
                        txtMasv.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Tensv",
                        txtTensv.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Cccd",
                        txtCCCD.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Gioitinh",
                        cboGioitinh.SelectedIndex == 0);

                    cmd.Parameters.AddWithValue(
                        "@Ngaysinh",
                        dtpNgaysinh.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Malop",
                        cboMalop.SelectedValue);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Thêm sinh viên thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Load lại danh sách
                    LoadSinhVien();

                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể thêm sinh viên!\n\n" + ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            try
            {
                using (SqlConnection conn = ConnectDB.GetConnection())
                {
                    string sql = @"
                        UPDATE Sinhvien
                        SET
                            Tensv = @Tensv,
                            Cccd = @Cccd,
                            Gioitinh = @Gioitinh,
                            Ngaysinh = @Ngaysinh,
                            Malop = @Malop
                        WHERE Masv = @Masv";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Masv",
                        txtMasv.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Tensv",
                        txtTensv.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Cccd",
                        txtCCCD.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Gioitinh",
                        cboGioitinh.SelectedIndex == 0);

                    cmd.Parameters.AddWithValue(
                        "@Ngaysinh",
                        dtpNgaysinh.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Malop",
                        cboMalop.SelectedValue);

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Cập nhật sinh viên thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadSinhVien();

                        

                        txtMasv.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy sinh viên cần sửa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = ConnectDB.GetConnection())
                {
                    string sql =
                        "DELETE FROM Sinhvien WHERE Masv = @Masv";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Masv",
                        txtMasv.Text.Trim());

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Xóa sinh viên thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadSinhVien();

                        
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy sinh viên!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể xóa sinh viên.\n\n" +
                    "Có thể sinh viên đang được sử dụng ở bảng khác.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void dgvSinhvien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row =
                    dgvSinhvien.Rows[e.RowIndex];

                txtMasv.Text =
                    row.Cells["Masv"].Value.ToString();

                txtTensv.Text =
                    row.Cells["Tensv"].Value.ToString();

                txtCCCD.Text =
                    row.Cells["Cccd"].Value.ToString();

                //Gioiws tinh
                cboGioitinh.Text = row.Cells["Gioitinh"].Value.ToString();

                // Ngày sinh
                dtpNgaysinh.Value =
                    Convert.ToDateTime(
                        row.Cells["Ngaysinh"].Value);

                // Mã lớp
                cboMalop.SelectedValue =
                    row.Cells["Malop"].Value?.ToString();

                // Không cho sửa mã sinh viên
                txtMasv.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lấy thông tin sinh viên!\n\n" +
                    ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMasv.Clear();
            txtTensv.Clear();
            txtCCCD.Clear();
            //txtTimkiem.Clear();

            txtMasv.Enabled = true;

            if (cboGioitinh.Items.Count > 0)
            {
                cboGioitinh.SelectedIndex = 0;
            }

            if (cboMalop.Items.Count > 0)
            {
                cboMalop.SelectedIndex = 0;
            }

            dtpNgaysinh.Value = DateTime.Now;

            LoadSinhVien();

            txtMasv.Focus();
        }
    }
    }

