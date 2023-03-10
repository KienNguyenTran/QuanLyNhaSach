using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance1;
        public static DataProvider Instance
        {
            get { if (instance1 == null) instance1 = new DataProvider(); return instance1; }
            private set { DataProvider.instance1 = value; }
        }
        private DataProvider() { }

        private string conSTR = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                connection.Close();
            }
            return data;

        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

               data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;

        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;

        }
    }
}
