using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class DataProvider
    {
        //Design Pattern Singleton//
        private static DataProvider instance; //CTRL + R  + E -->PACKED.

        //get and set (it was packed). (is null)
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            set
            {
                DataProvider.instance = value;
            }
        }

        //Constructor
        private DataProvider() { }

        string strcnn = @"Data Source=LAPTOP-KLRCJPU6\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True";

        #region USE TO SELECT
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            //giải phóng bộ nhớ.
            using (SqlConnection cnn = new SqlConnection(strcnn))
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(query, cnn);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(data);
                cnn.Close();
            }

            return data;
        }
        #endregion

        #region USE TO INSET, DELETE, UPDATE
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            //giải phóng bộ nhớ.
            using (SqlConnection cnn = new SqlConnection(strcnn))
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(query, cnn);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                cnn.Close();
            }

            return data;
        }
        #endregion

        #region USE TO COUNT
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            //giải phóng bộ nhớ.
            using (SqlConnection cnn = new SqlConnection(strcnn))
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(query, cnn);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                cnn.Close();
            }

            return data;
        }
        #endregion

    }
}
