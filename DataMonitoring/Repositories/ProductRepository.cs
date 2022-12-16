using DataMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace DataMonitoring.Repositories
{
    public class ProductRepository
    {
        string connectionString;

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product;

            var data = GetProductDetailsFromDb();

            foreach (DataRow row in data.Rows)
            {
                product = new Product
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Category = row["Category"].ToString(),
                    Quantity = Convert.ToInt32( row["Quantity"]),
                    Price = Convert.ToDecimal(row["Price"])
                };
                if(product.Quantity < 10)
                            {
                    try
                    {
                        SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        System.Net.NetworkCredential credential = new System.Net.NetworkCredential("testdev9@outlook.fr", "test2468");
                        client.EnableSsl = true;
                        client.Credentials = credential;
                        MailMessage message = new MailMessage("testdev9@outlook.fr", "rachednaguez9@gmail.com");
                        message.Subject = "Alert : ";
                        message.Body = "Recharger le stock du produit : " + product.Name;
                        message.IsBodyHtml = true;
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    products.Add(product);

                }
                        else
                {
                    products.Add(product);
                }
               // products.Add(product);
            }

            return products;
        }

        private DataTable GetProductDetailsFromDb()
        {
            var query = "SELECT Id, Name, Category,Quantity, Price FROM Product";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<ProductForGraph> GetProductsForGraph()
        {
            List<ProductForGraph> productsForGraph = new List<ProductForGraph>();
            ProductForGraph productForGraph;

            var data = GetProductsForGraphFromDb();

            foreach (DataRow row in data.Rows)
            {
                productForGraph = new ProductForGraph
                {
                    Category = row["Category"].ToString(),
                    Products = Convert.ToInt32(row["Products"])
                };
                productsForGraph.Add(productForGraph);
            }

            return productsForGraph;
        }

        private DataTable GetProductsForGraphFromDb()
        {
            var query = "SELECT Category, COUNT(Id) Products FROM Product GROUP BY Category";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
