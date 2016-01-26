using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.

    public class ShipperService : IShipperService
    {
        readonly string _settings = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
        public Shipper GetShipperId(int shipperId)
        {
            var shipper = new Shipper();

            string queryString =
                "SELECT * FROM dbo.Shippers WHERE ShipperID =" + shipperId;

            using (SqlConnection connection = new SqlConnection(_settings))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    shipper.ShipperId = int.Parse(reader["ShipperID"].ToString());
                    shipper.CompanyName = reader["CompanyName"].ToString();
                    shipper.Phone = reader["Phone"].ToString();
                }
            }
            return shipper;
        }

        public void SaveShipper(Shipper shipper)
        {
            using (SqlConnection connection = new SqlConnection(_settings))
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE dbo.Shippers SET CompanyName = @companyName, Phone = @phone WHERE ShipperID = @shipperId")
                    {
                        CommandType = CommandType.Text,
                        Connection = connection
                    };
                cmd.Parameters.AddWithValue("@companyName", shipper.CompanyName);
                cmd.Parameters.AddWithValue("@phone", shipper.Phone);
                cmd.Parameters.AddWithValue("@shipperId", shipper.ShipperId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
