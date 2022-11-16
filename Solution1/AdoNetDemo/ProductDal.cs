using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoNetDemo
{
    public class ProductDal
    {

        SqlConnection _conn = new SqlConnection(@"server=DESKTOP-KVIRVD3;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();


            //SqlConnection _conn = new SqlConnection(@"server=DESKTOP-KVIRVD3;initial catalog=ETrade;integrated security=false;uid=arif;password=1234");  {uzak server a bağlanırken böyle}

            SqlCommand command = new SqlCommand("Select * from Products", _conn);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();

            _conn.Close();

            return products;
        }

        private void ConnectionControl()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        //public List<Product> GetAll()
        //{


        //    SqlConnection _conn = new SqlConnection(@"server=DESKTOP-KVIRVD3;initial catalog=ETrade;integrated security=false;uid=arif;password=1234");
        //    { uzak server a bağlanırken böyle}

        //    SqlConnection _conn = new SqlConnection(@"server=DESKTOP-KVIRVD3;initial catalog=ETrade;integrated security=true");

        //    if (_conn.State == ConnectionState.Closed)
        //    {
        //        _conn.Open();
        //    }

        //    SqlCommand command = new SqlCommand("Select * from Products", _conn);

        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable dt = new DataTable();

        //    dt.Load(reader);

        //    reader.Close();

        //    _conn.Close();

        //    return dt;


        //}

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products values(@Name,@UnitPrice,@StockAmount)", _conn);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _conn.Close();
        }


        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand update = new SqlCommand("UPDATE Products set Name=@Name, UnitPrice = @UnitPrice, StockAmount = @StockAmount where Id=@Id", _conn);
            update.Parameters.AddWithValue("@Name", product.Name);
            update.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            update.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            update.Parameters.AddWithValue("@Id", product.Id);
            update.ExecuteNonQuery();

            _conn.Close();
        }


        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand delete = new SqlCommand("DELETE FROM Products WHERE Id=@Id", _conn);
            delete.Parameters.AddWithValue("@Id", Id);
            delete.ExecuteNonQuery();
            
            _conn.Close();
        }
    }
}
