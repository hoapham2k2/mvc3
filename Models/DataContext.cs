using MySql.Data.MySqlClient;
using mvc3.Models;
using System.Collections.Generic;
using System;

namespace mvc3.Models{
    public class DataContext{
        public string ConnectionString {get;set;}

        public DataContext(string connectionString){
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection(){
            return new MySqlConnection(ConnectionString);
        }

        public int InsertCH(CanHo ch){
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into CanHo values(@MaCanHo, @TenChuHo)", conn);
                cmd.Parameters.AddWithValue("@MaCanHo", ch.MaCanHo);
                cmd.Parameters.AddWithValue("@TenChuHo", ch.TenChuHo);
                cmd.ExecuteNonQuery();
                return cmd.ExecuteNonQuery();
            }

        }

        public List<object> GetListNVBT(int SoLanSua){
            List<object> list = new List<object>();
            
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select count(*) as solansua, tennhanvien, sodienthoai from NV_BT n1 join nhanvien n2 on n1.manhanvien = n2.manhanvien group by n1.manhanvien having count(*) >= @solansua", conn);
                cmd.Parameters.AddWithValue("@solansua", SoLanSua);
                using(MySqlDataReader reader = cmd.ExecuteReader()){
                    while(reader.Read()){
                        var ob = new {
                            solansua = reader["solansua"],
                            tennhanvien = reader["tennhanvien"],
                            sodienthoai = reader["sodienthoai"]
                        };
                        list.Add(ob);
                    }
                }
            }
            return list;
        }


        public List<NhanVien> GetNhanViens(){
        
            List<NhanVien> list = new List<NhanVien>();
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from nhanvien", conn);
                using (MySqlDataReader  reader = cmd.ExecuteReader()){
                    while(reader.Read()){
                        var nv = new NhanVien(){
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString()
                        };
                        list.Add(nv);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }


        public List<NVBT> GetListNVBT(string MaNhanVien){
            List<NVBT> list = new List<NVBT>();
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from NV_BT where manhanvien = @manhanvien",conn);
                cmd.Parameters.AddWithValue("@manhanvien",MaNhanVien);
                using(MySqlDataReader reader = cmd.ExecuteReader()){
                    while(reader.Read()){
                        var nvbt = new NVBT(){
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = reader["NgayBaoTri"].ToString(),
                        };
                        list.Add(nvbt);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //  public int InsertCH(CanHo ch){
        //     using(MySqlConnection conn = GetConnection()){
        //         conn.Open();
        //         MySqlCommand cmd = new MySqlCommand("insert into CanHo values(@MaCanHo, @TenChuHo)", conn);
        //         cmd.Parameters.AddWithValue("@MaCanHo", ch.MaCanHo);
        //         cmd.Parameters.AddWithValue("@TenChuHo", ch.TenChuHo);
        //         cmd.ExecuteNonQuery();
        //         return cmd.ExecuteNonQuery();
        //     }

        // }

        public int DeleteNVBT(string MaNhanVien, string MaThietBi, string MaCanHo,string LanThu){
            
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from  NV_BT where manhanvien = @manhanvien and mathietbi = @mathietbi and macanho = @macanho", conn);
                cmd.Parameters.AddWithValue("@manhanvien", MaNhanVien);
                cmd.Parameters.AddWithValue("@mathietbi", MaThietBi);
                cmd.Parameters.AddWithValue("@macanho", MaCanHo);
                cmd.Parameters.AddWithValue("@lanthu", LanThu);
             
                return cmd.ExecuteNonQuery();
            }
        }

        public NVBT ViewNVBT(string MaNhanVien, string MaThietBi, string MaCanHo, string LanThu){
            NVBT nvbt = new NVBT();
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from nv_bt where manhanvien = @manhanvien and macanho = @macanho and mathietbi = @mathietbi and lanthu = @lanthu",conn);
                cmd.Parameters.AddWithValue("@manhanvien",MaNhanVien);
                cmd.Parameters.AddWithValue("@macanho",MaCanHo);
                cmd.Parameters.AddWithValue("@mathietbi",MaThietBi);
                cmd.Parameters.AddWithValue("@lanthu",LanThu);
                
                using(MySqlDataReader reader = cmd.ExecuteReader()){
                    while(reader.Read()){
                      var nv = new NVBT(){
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = reader["NgayBaoTri"].ToString(),
                        };
                        nvbt = nv;
                    }
                    reader.Close();

                }
                conn.Close();
                
            }
            return nvbt;
        }

        public int UpdateNVBT(string MaNhanVien, string MaThietBi, string MaCanHo, string LanThu, string NgayBaoTri){
            using(MySqlConnection conn = GetConnection()){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update NV_BT set ngaybaotri = @ngaybaotri, macanho = @macanho, mathietbi = @mathietbi, lanthu = @lanthu, ngaybaotri = @ngaybaotri  where manhanvien = @manhanvien ", conn);
                cmd.Parameters.AddWithValue("@manhanvien", MaNhanVien);
                cmd.Parameters.AddWithValue("@mathietbi", MaThietBi);
                cmd.Parameters.AddWithValue("@macanho", MaCanHo);
                cmd.Parameters.AddWithValue("@lanthu", LanThu);
                cmd.Parameters.AddWithValue("@ngaybaotri", NgayBaoTri);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}