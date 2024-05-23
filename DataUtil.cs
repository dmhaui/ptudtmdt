using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;


namespace masterpage2
{
    public class DataUtil
    {
        SqlConnection con;
        public DataUtil()
        {
            string sqlCon = @"Data Source=2M\SQLEXPRESS;Initial Catalog=mydata;Integrated Security=True";
            con = new SqlConnection(sqlCon);
        }

        public List<Employees> dsnhanvien()
        {
            List<Employees> ds = new List<Employees>();
            string sql = "select * from Employees";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Employees s = new Employees();
                s.empid = (int)rd["empid"];
                s.name = (string)rd["name"];
                s.gender = (string)rd["gender"];
                s.address = (string)rd["address"];
                s.email = (string)rd["email"];
                s.titleid = (int)rd["titleid"];

                ds.Add(s);
            }
            con.Close();

            return ds;
        }

        //list phong
        public List<Titles> dsPhong()
        {
            List<Titles> ds = new List<Titles>();
            string sql = "select * from Titles";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Titles s = new Titles();
                s.titleid = (int)rd["titleid"];
                s.name = (string)rd["name"];

                ds.Add(s);
            }
            con.Close();

            return ds;
        }
        //them nv
        public void themnv(Employees s)
        {
            con.Open();
            string sql = "insert into Employees values (@ten,@gt,@dc,@email,@map)";
            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.AddWithValue("ma", s.empid);
            cmd.Parameters.AddWithValue("ten", s.name);
            cmd.Parameters.AddWithValue("gt", s.gender);
            cmd.Parameters.AddWithValue("dc", s.address);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("map", s.titleid);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        //xoa nv
        public void Xoasv(int empid)
        {
            con.Open();
            string sql = "delete from Employees where empid=@empid ";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("empid", empid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //lay nv de sua
        public Employees laynv(int empid)
        {
            
            string sql = "select * from Employees where empid=@empid ";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("empid", empid);

            Employees s = null;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new Employees();
                s.empid = (int)rd["empid"];
                s.name = (string)rd["name"];
                s.gender = (string)rd["gender"];
                s.address = (string)rd["address"];
                s.email = (string)rd["email"];
                s.titleid = (int)rd["titleid"];

            }
            con.Close();

            return s;
        }

        //sua nhan vien
        public void suanv(Employees s)
        {
            con.Open();
            string sql = "update Employees set name=@ten,gender=@gt,address=@dc,email=@email,titleid=@map where empid=@ma";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("ma", s.empid);
            cmd.Parameters.AddWithValue("ten", s.name);
            cmd.Parameters.AddWithValue("gt", s.gender);
            cmd.Parameters.AddWithValue("dc", s.address);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("map", s.titleid);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}