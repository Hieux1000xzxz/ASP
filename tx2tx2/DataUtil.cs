using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
namespace tx2tx2
{
    
    public class DataUtil
    {
        SqlConnection con;
        public DataUtil() {
            string sqlCon = @"Data Source=MCCOMPUTER;Initial Catalog=mydata;Integrated Security=True;TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);
        }
        public List<tblChuyenDi> DSChuyenDi()
        {
            List<tblChuyenDi> ds = new List<tblChuyenDi>();
            string sql = "Select * from tblChuyenDi";
            con.Open();
            SqlCommand Cmd = new SqlCommand(sql, con);
            SqlDataReader rd = Cmd.ExecuteReader(0);
            while (rd.Read())
            {
                tblChuyenDi cd = new tblChuyenDi();
                cd.macd = (int)rd["macd"];
                cd.tencd = (string)rd["tencd"];
                cd.songaydi = (int)rd["songaydi"];
                cd.songuoidi = (int)rd["songuoidi"];
                cd.mapt = (int)rd["mapt"];
                ds.Add(cd);
            }
            con.Close();
            return ds;
        }

        public List<tblPhuongTien> DSPhuongTien()
        {
            List<tblPhuongTien> ds = new List<tblPhuongTien>();
            string sql = "Select * from tblPhuongTien";
            con.Open();
            SqlCommand Cmd = new SqlCommand(sql, con);
            SqlDataReader rd = Cmd.ExecuteReader(0);
            while (rd.Read())
            {
                tblPhuongTien pt = new tblPhuongTien();
                pt.mapt = (int)rd["mapt"];
                pt.tenpt = (string)rd["tenpt"];
                pt.giatien = (double)(decimal)rd["giatien"];
                ds.Add(pt);
            }
            con.Close();
            return ds;
        }
        public void ThemCD(tblChuyenDi cd)
        {
            con.Open();
            string sql = "Insert into tblChuyenDi values(@tencd,@songaydi,@songuoidi,@mapt)";
            SqlCommand Cmd = new SqlCommand(sql, con);
            Cmd.Parameters.AddWithValue("tencd", cd.tencd);
            Cmd.Parameters.AddWithValue("songaydi", cd.songaydi);
            Cmd.Parameters.AddWithValue("songuoidi", cd.songuoidi);
            Cmd.Parameters.AddWithValue("mapt", cd.mapt);
            Cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaCD(int macd)
        {
            con.Open();
            string sql = "Delete from tblChuyenDi where macd=@macd";
            SqlCommand Cmd = new SqlCommand(sql, con);
            Cmd.Parameters.AddWithValue("macd", macd);
            Cmd.ExecuteNonQuery();
            con.Close();

        }
        public tblChuyenDi Lay1ChuyenDi(int macd)
        {
            List<tblChuyenDi> ds = new List<tblChuyenDi>();
            string sql = "Select * from tblChuyenDi where macd=@macd";
            con.Open();
            SqlCommand Cmd = new SqlCommand(sql, con);
            Cmd.Parameters.AddWithValue("macd", macd);
            tblChuyenDi cd = null;
            SqlDataReader rd = Cmd.ExecuteReader();
            if (rd.Read())
            {
                cd = new tblChuyenDi();
                cd.macd = (int)rd["macd"];
                cd.tencd = (string)rd["tencd"];
                cd.songaydi = (int)rd["songaydi"];
                cd.songuoidi = (int)rd["songuoidi"];
                cd.mapt = (int)rd["mapt"];
            }
            con.Close();
            return cd;
        }
        public void CapnhatCD(tblChuyenDi cd)
        {
            con.Open();
            string sql = "update tblChuyenDi set tencd=@tencd, songaydi=@songaydi, songuoidi=@songuoidi, mapt=@mapt where macd=@macd";
            SqlCommand Cmd = new SqlCommand(sql, con);
            Cmd.Parameters.AddWithValue("tencd", cd.tencd);
            Cmd.Parameters.AddWithValue("songaydi", cd.songaydi);
            Cmd.Parameters.AddWithValue("songuoidi", cd.songuoidi);
            Cmd.Parameters.AddWithValue("mapt", cd.mapt);
            Cmd.Parameters.AddWithValue("macd", cd.macd);
            Cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}