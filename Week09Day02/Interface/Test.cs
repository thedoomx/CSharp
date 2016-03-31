using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Test
    {
        //static void Main(string[] args)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

        //    string query = @"SELECT [ID],
        //                        [Name],
        //                        [Email],
        //                        [DateOfBirth],
        //                        [ManagerID],
        //                        [DepartmentID]
        //                    FROM [Employees]
        //                    WHERE ID > @TargetID";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        var command = new SqlCommand(query, connection);

        //        var parameter = new SqlParameter("@TargetID", System.Data.SqlDbType.Int);
        //        parameter.Value = 5;

        //        command.Parameters.Add(parameter);

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while(reader.Read())
        //            {
        //                string name = GetStringOrNull(reader["Name"]);
        //                string email = GetStringOrNull(reader["Email"]);

        //                string full = string.Format("{0}, {1}", name, email);
        //                Console.WriteLine(full);
        //            }
        //        }
        //    }
        //}

        //private static string GetStringOrNull(object value)
        //{
        //    if (value is DBNull)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return (string)value;
        //    }
        //}
    }
}
