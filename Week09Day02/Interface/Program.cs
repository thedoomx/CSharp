using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Configuration;
using System.Data.SqlClient;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            e.Id = 30;
            e.Name = "VS TEST";

            Console.WriteLine(InsertDTOEmployee(e));
        }

        private static string GetStringOrNull(object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            else
            {
                return (string)value;
            }
        }

        private static int GetIntOrZero(object value)
        {
            if (value is DBNull)
            {
                return 0;
            }
            else
            {
                return (int)value;
            }
        }

        private static DateTime GetDateOrNull(object value)
        {
            if (value is DBNull)
            {
                return DateTime.MinValue;
            }
            else
            {
                return (DateTime)value;
            }
        }

        private static float GetFloatOrZero(object value)
        {
            if(value is DBNull)
            {
                return 0;
            }
            else
            {
                return (float)value;
            }
        }

        private static decimal GetDecimalOrZero(object value)
        {
            if(value is DBNull)
            {
                return 0;
            }
            else
            {
                return (decimal)value;
            }
        }

        public static List<Employees> GetEmployees()
        {
            List<Employees> list = new List<Employees>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [Name],
                                [Email],
                                [DateOfBirth],
                                [ManagerID],
                                [DepartmentID]
                            FROM [Employees]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employees temp = new Employees();
                        temp.Id = GetIntOrZero(reader["ID"]);
                        temp.Name = GetStringOrNull(reader["Name"]);
                        temp.Email = GetStringOrNull(reader["Email"]);
                        temp.DateOfBirth = GetDateOrNull(reader["DateOfBirth"]);
                        temp.ManagerId = GetIntOrZero(reader["ManagerID"]);
                        temp.DepartmentId = GetIntOrZero(reader["DepartmentID"]);

                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [Code],
                                [Name]
                            FROM [Category]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category temp = new Category();
                        temp.ID = GetIntOrZero(reader["ID"]);
                        temp.Name = GetStringOrNull(reader["Name"]);
                        temp.Code = GetStringOrNull(reader["Code"]);
                        
                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<Customers> GetCustomers()
        {
            List<Customers> list = new List<Customers>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [Name],
                                [Email],
                                [CustomerAddress],
                                [Discount]
                             FROM [Customers]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customers temp = new Customers();
                        temp.ID = GetIntOrZero(reader["ID"]);
                        temp.Name = GetStringOrNull(reader["Name"]);
                        temp.Email = GetStringOrNull(reader["Email"]);
                        temp.CustomerAddress = GetStringOrNull(reader["CustomerAddress"]);
                        temp.Discount = GetIntOrZero(reader["Discount"]);

                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [Name]
                            FROM [Department]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Department temp = new Department();
                        temp.ID = GetIntOrZero(reader["ID"]);
                        temp.Name = GetStringOrNull(reader["Name"]);

                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<OrderProducts> GetOrderProducts()
        {
            List<OrderProducts> list = new List<OrderProducts>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [OrderID],
                                [ProductID],
                                [Quantity]
                            FROM [OrderProducts]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderProducts temp = new OrderProducts();
                        temp.OrderID = GetIntOrZero(reader["OrderID"]);
                        temp.ProductID = GetIntOrZero(reader["ProductID"]);
                        temp.Quantity = GetIntOrZero(reader["Quantity"]);
                        
                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<Orders> GetOrders()
        {
            List<Orders> list = new List<Orders>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [DateAndTimeOfOrder],
                                [TotalPrice],
                                [CustomerID]
                            FROM [Orders]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Orders temp = new Orders();
                        temp.ID = GetIntOrZero(reader["ID"]);
                        temp.TotalPrice = GetIntOrZero(reader["Name"]);
                        temp.CustomerID = GetIntOrZero(reader["Email"]);
                        temp.DateAndTimeOfOrder = GetDateOrNull(reader["DateAndTimeOfOrder"]);

                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = @"SELECT [ID],
                                [Name],
                                [SinglePrice],
                                [CategoryID]
                            FROM [Product]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product temp = new Product();
                        temp.ID = GetIntOrZero(reader["ID"]);
                        temp.Name = GetStringOrNull(reader["Name"]);
                        temp.SinglePrice = GetDecimalOrZero(reader["SinglePrice"]);
                        temp.CategoryID = GetIntOrZero(reader["CategoryID"]);

                        list.Add(temp);
                    }
                }
            }

            return list;
        }

        public static Product GetDTOProduct(int id)
        {
            List<Product> products = GetProducts();

            foreach (var item in products)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Orders GetDTOOrder(int id)
        {
            List<Orders> orders = GetOrders();

            foreach (var item in orders)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static OrderProducts GetDTOOrderProducts(int orderID, int productID)
        {
            List<OrderProducts> orderProducts = GetOrderProducts();

            foreach (var item in orderProducts)
            {
                if (item.OrderID == orderID && item.ProductID == productID)
                {
                    return item;
                }
            }

            return null;
        }

        public static Employees GetDTOEmployee(int id)
        {
            List<Employees> employees = GetEmployees();

            foreach (var item in employees)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Department GetDTODepartment(int id)
        {
            List<Department> departments = GetDepartments();

            foreach (var item in departments)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Customers GetDTOCustomer(int id)
        {
            List<Customers> customers = GetCustomers();

            foreach (var item in customers)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Category GetDTOCategory(int id)
        {
            List<Category> categories = GetCategories();

            foreach (var item in categories)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static bool DelProductID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Product]
                            WHERE [Product].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if(affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelOrdersID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Orders]
                            WHERE [Orders].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelOrderProductsID(int orderID, int productID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [OrderProducts]
                            WHERE [OrderProducts].OrderID = {0} AND [OrderProducts].ProductID = {1}", orderID, productID);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelEmployeesID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Employees]
                            WHERE [Employees].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelDepartmentID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Department]
                            WHERE [Department].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelCustomerID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Customers]
                            WHERE [Customers].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool DelCategoryID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"DELETE FROM [Category]
                            WHERE [Category].ID = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool InsertDTOEmployee(Employees e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Week08Day03"].ConnectionString;

            string query = string.Format(@"IF EXISTS (SELECT * FROM Employees WHERE id = {0})
                                            BEGIN
	                                            UPDATE Employees
	                                            SET Name = 'First'
	                                            WHERE ID = {0}
                                            END
                                            ELSE
                                            BEGIN
	                                            INSERT INTO Employees
	                                            VALUES ('{1}', NULL, '1900-01-01', 2, 2)
                                            END", e.Id, e.Name);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
