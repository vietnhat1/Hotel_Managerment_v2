using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public class LopDungChung
    {
        public readonly string duongDan = @"Server=.\SQLEXPRESS;Database=HotelManager;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=120;";
        private SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(duongDan);
        }

        // ===== Load dữ liệu (có hoặc không tham số)
        public DataTable LoadDuLieu(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (parameters != null)
                {
                    da.SelectCommand.Parameters.Clear();
                    foreach (var param in parameters)
                    {
                        da.SelectCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
                return null;
            }
        }

        // ===== NonQuery đơn giản
        public void NonQuery(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(result > 0 ? "Thành công" : "Thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                conn.Close();
            }
        }

        // ===== NonQuery có tham số + tuỳ chọn thông báo
        public bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null, bool showMessage = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (showMessage)
                {
                    MessageBox.Show(result > 0 ? "Thành công" : "Thất bại");
                }

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ExecuteNonQuery: " + ex.Message);
                conn.Close();
                return false;
            }
        }

        // ===== Scalar đơn giản
        public object Scalar(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Scalar: " + ex.Message);
                conn.Close();
                return null;
            }
        }

        // ===== Scalar nâng cao
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            return Scalar(query, parameters);
        }

        // ===== Scalar hỗ trợ tham số
        public object Scalar(string query, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Scalar (tham số): " + ex.Message);
                conn.Close();
                return null;
            }
        }

        // ===== Dùng khi không muốn hiển thị thông báo
        public void SuaKhongThongBao(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
                conn.Close();
            }
        }
    }
}
