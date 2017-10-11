using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BaseDataAccess
    {
        public static bool ExecuteSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;

                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch(Exception ex)
            {
                return false;
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public static DBHelper GetDBHelper(string sql)
        {
            DBHelper helper = new DataAccess.DBHelper();
            helper.connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            helper.connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = helper.connection;

            command.CommandText = sql;

            helper.DataReader = command.ExecuteReader();

            return helper;
        }

        public static T FillObject<T>(SqlDataReader dr)
        {
            if (dr.Read())
            {
                T obj = (T)System.Activator.CreateInstance(typeof(T));
                System.Reflection.PropertyInfo[] allProperties = obj.GetType().GetProperties();

                foreach (System.Reflection.PropertyInfo property in allProperties)
                {
                    try
                    {
                        if (dr[property.Name] != System.DBNull.Value)
                        {
                            property.SetValue(obj, dr[property.Name]);
                        }
                    }
                    catch
                    {

                    }
                }
                return obj;
            }
            return default(T);
        }

        public static List<T> FillList<T>(SqlDataReader dr)
        {
            T obj = default(T);
            List<T> list = new List<T>();
            while (dr.Read())
            {
                obj = (T)System.Activator.CreateInstance(typeof(T));

                System.Reflection.PropertyInfo[] allProperties = obj.GetType().GetProperties();
                foreach (System.Reflection.PropertyInfo property in allProperties)
                {
                    try
                    {
                        if (dr[property.Name] != System.DBNull.Value)
                        {
                            property.SetValue(obj, dr[property.Name]);
                        }
                    }
                    catch(Exception ex)
                    {

                    }

                }
                list.Add(obj);
            }

            
            return list;
        }

        public static T GetRecords<T>(string sql)
        {
            DBHelper helper = GetDBHelper(sql);
            T obj = default(T);

            try
            {
               obj= FillObject<T>(helper.DataReader);

                return obj;
            }

            catch
            {
                return default(T);
            }

            finally
            {
                if (helper.connection.State == System.Data.ConnectionState.Open)
                {
                    helper.connection.Close();
                }
            }
        }

        public static List<T> GetRecordsList<T>(string sql)
        {
            DBHelper helper = GetDBHelper(sql);
            try
            {
                List<T> list = FillList<T>(helper.DataReader);

                return list;
            }

            catch
            {
                return null;
            }

            finally
            {
                if (helper.connection.State == System.Data.ConnectionState.Open)
                {
                    helper.connection.Close();
                }
            }
        }
    }
}
