using System;
using System.Configuration; // For accessing connection strings
using Microsoft.Data.SqlClient; // Ensure you're using this namespace only

namespace Mini_Cs
{
    public class DatabaseManager
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public void SaveCustomer(CustomerData customerData)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
            INSERT INTO Customers (ServiceType, WithLifePlan, LifePlanOtherDetails, ServiceDate) 
            OUTPUT INSERTED.CustomerID
            VALUES (@ServiceType, @WithLifePlan, @LifePlanOtherDetails, @ServiceDate)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServiceType", customerData.ServiceType ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@WithLifePlan", customerData.WithLifePlan ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@LifePlanOtherDetails", customerData.LifePlanOtherDetails ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ServiceDate", customerData.ServiceDate ?? (object)DBNull.Value);

                        connection.Open();
                        customerData.CustomerID = Convert.ToInt32(command.ExecuteScalar());
                        Console.WriteLine($"Customer saved with ID: {customerData.CustomerID}"); // Debug log
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveCustomer: {ex.Message}"); // Log the error for debugging
                throw; // Re-throw for higher-level handling
            }
        }

        public void SaveDeceasedInfo(DeceasedInfoData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
            INSERT INTO DeceasedInfo (CustomerID, Name, Address, Gender, CivilStatus, Birthdate, OSCAPWDID, DateOfDeath) 
            VALUES (@CustomerID, @Name, @Address, @Gender, @CivilStatus, @Birthdate, @OSCAPWDID, @DateOfDeath)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@Name", data.Name);
                        command.Parameters.AddWithValue("@Address", data.Address);
                        command.Parameters.AddWithValue("@Gender", data.Gender);
                        command.Parameters.AddWithValue("@CivilStatus", data.CivilStatus);
                        command.Parameters.AddWithValue("@Birthdate", data.Birthdate);
                        command.Parameters.AddWithValue("@OSCAPWDID", data.OSCAPWDID);
                        command.Parameters.AddWithValue("@DateOfDeath", data.DateOfDeath);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"DeceasedInfo saved for CustomerID: {data.CustomerID}"); // Debug log
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveDeceasedInfo: {ex.Message}"); // Log the error for debugging
                throw;
            }
        }

    }
}
