/* Author: Simon Harris
 * Much of this code is referenced from Rached, E.'s work
 * https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2.DatabaseUtilities
{
    class DBConnection
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string pass;

        // This is kind of a mess, I learned a bit more about database connections
        // I at least hope the names and formatting are descriptive enough to give 
        // the reader an idea of what is happening.

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "dbm405a_courseproject";
            uid = "BOOKSQL";
            pass = "BOOKSQLPW";
            string connectionString;
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + pass + ";";

            conn = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Conneciton Failed");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid User/Pass");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<string>[] SelectAllFromCustomer()
        {
            string query = "SELECT * FROM customer;";

            List<string>[] customerList = new List<string>[9];
            for (int i = 0; i < 9; i++)
            {
                customerList[i] = new List<string>();
            }

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    customerList[0].Add(dataReader["customerId"] + "");
                    customerList[1].Add(dataReader["firstName"] + "");
                    customerList[2].Add(dataReader["lastName"] + "");
                    customerList[3].Add(dataReader["email"] + "");
                    customerList[4].Add(dataReader["phone"] + "");
                    customerList[5].Add(dataReader["address"] + "");
                    customerList[6].Add(dataReader["city"] + "");
                    customerList[7].Add(dataReader["state"] + "");
                    customerList[8].Add(dataReader["zipCode"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return customerList;
            }
            else
            {
                return customerList;
            }
        }

        public List<string> SelectSpecificFromTable (string column, string table)
        {
            string query =  "SELECT "+ column + " " +
                            "FROM " + table + ";";

            List<string> list = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader[column].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public void DeleteConditionFromTable(string table, string whereCondition)
        {
            string query = "DELETE FROM " + table + " " +
                "WHERE " + whereCondition;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + " rows removed.");
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Conection failed.");
            }
        }

        public Customer RetrieveCustomerViaEmail(string email)
        {
            Customer customer = new Customer();

            string query = "SELECT * " +
                            "FROM customer " +
                            "WHERE email = '" + email + "';";

            List<string> list = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    customer.CustomerId = Int32.Parse(dataReader["customerId"].ToString());
                    customer.FirstName = dataReader["firstName"] + "";
                    customer.LastName = dataReader["lastName"] + "";
                    customer.Email = dataReader["email"] + "";
                    customer.Phone = dataReader["phone"] + "";
                    customer.Address = dataReader["address"] + "";
                    customer.City = dataReader["city"] + "";
                    customer.State = dataReader["state"] + "";
                    customer.Zip = dataReader["zipCode"] + "";
                }
                dataReader.Close();
                this.CloseConnection();
                return customer;
            }
            else
            {
                return customer;
            }
        }

        public bool AddCustomerToDatabase(Customer cust)
        {
            string query = "INSERT INTO customer " +
                "(firstName, lastName, email, phone, address, city, state, zipcode) " +
                "VALUES ('" +
                cust.FirstName + "', '" +
                cust.LastName + "', '" +
                cust.Email + "', '" +
                cust.Phone + "', '" +
                cust.Address + "', '" +
                cust.City + "', '" +
                cust.State + "', '" +
                cust.Zip + "');";
            bool valid = false;


            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Customer added successfully");
                    valid = true;
                }
                this.CloseConnection();
            }

            return valid;
        }

        public bool UpdateCustomerInfo(Customer cust)
        {
            string query = "UPDATE customer " +
                "SET firstname = '" + cust.FirstName + "', " +
                "lastname = '" + cust.LastName + "', " +
                "phone= '" + cust.Phone + "', " +
                "address = '" + cust.Address + "', " +
                "city = '" + cust.City + "', " +
                "state = '" + cust.State + "', " +
                "zipCode = '" + cust.Zip + "' " +
                "WHERE email = '" + cust.Email + "';";
            if (ExecuteNonQuery(query) > -1) { return true; }
            return false;
        }

        public bool AddProductToDataBase(Product prod)
        {
            string query = "INSERT INTO products " +
                "(productName, productPrice, description) " +
                "VALUES ('" +
                prod.Name + "', " +
                prod.Price + ", '" +
                prod.Description + "');";

            if (ExecuteNonQuery(query) > -1) { return true; }
            return false;
        }

        public bool UpdateProductInfo(Product prod)
        {
            string query = "UPDATE products " +
                "SET productName = '" + prod.Name + "', " +
                "productPrice = " + prod.Price + ", " +
                "description = '" + prod.Description + "' " +
                "WHERE productId = " + prod.Id + ";";
            bool valid = false;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Update Successful");
                    valid = true;
                }
                else
                {
                    MessageBox.Show("Update Failed.");
                }
                this.CloseConnection();
            }
            return valid;
        }

        public List<Product> RetrieveProductsFromDatabase()
        {
            string query = "SELECT * FROM dbm405a_courseProject.products";
            List<Product> pList = new List<Product>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                /* Product Table Key:
                 * [0] ProductID
                 * [1] ProductName
                 * [2] ProductPrice
                 * [3] Decsription
                 * */

                while (dr.Read())
                {
                    Product p = new Product(
                        Int32.Parse(dr[0].ToString()),
                        dr[1].ToString(),
                        double.Parse(dr[2].ToString()),
                        dr[3].ToString());

                    pList.Add(p);
                }
                this.CloseConnection();
            }

            return pList;
        }

        private int ExecuteNonQuery (string query)
        {
            int rowsAffected = 0;
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rowsAffected = cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            return rowsAffected;
        }
    }
}
