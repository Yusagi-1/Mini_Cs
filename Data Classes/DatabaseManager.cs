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
        public void SaveServiceDetails(ServiceDetailsData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO ServiceDetails (CustomerID, CasketCode, UrnCode, ViewingPlace, EmbalmingDays, Autopsy) 
                VALUES (@CustomerID, @CasketCode, @UrnCode, @ViewingPlace, @EmbalmingDays, @Autopsy)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@CasketCode", data.CasketCode ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@UrnCode", data.UrnCode ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ViewingPlace", data.ViewingPlace ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@EmbalmingDays", data.EmbalmingDays);
                        command.Parameters.AddWithValue("@Autopsy", data.Autopsy);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"ServiceDetails saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveServiceDetails: {ex.Message}");
                throw;
            }
        }

        // Save DeathCertificationData
        public void SaveDeathCertification(DeathCertificationData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO DeathCertification (CustomerID, IssuedBy, OthersDetails) 
                VALUES (@CustomerID, @IssuedBy, @OthersDetails)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@IssuedBy", data.IssuedBy ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@OthersDetails", data.OthersDetails ?? (object)DBNull.Value);
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"DeathCertification saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveDeathCertification: {ex.Message}");
                throw;
            }
        }

        // Save DispositionDetailsData
        public void SaveDispositionDetails(DispositionDetailsData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO DispositionDetails (CustomerID, DispositionManner, DispositionOtherDetails, DispositionPlace, DispositionDateTime) 
                VALUES (@CustomerID, @DispositionManner, @DispositionOtherDetails, @DispositionPlace, @DispositionDateTime)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@DispositionManner", data.DispositionManner ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DispositionOtherDetails", data.DispositionOtherDetails ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DispositionPlace", data.DispositionPlace ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DispositionDateTime", data.DispositionDateTime ?? (object)DBNull.Value);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"DispositionDetails saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveDispositionDetails: {ex.Message}");
                throw;
            }
        }

        // Save VehiclesAssignedData
        public void SaveVehiclesAssigned(VehiclesAssignedData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO VehiclesAssigned (CustomerID, VehicleType, VehicleOtherDetails, DateReceivedByRepresentative) 
                VALUES (@CustomerID, @VehicleType, @VehicleOtherDetails, @DateReceivedByRepresentative)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@VehicleType", data.VehicleType ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@VehicleOtherDetails", data.VehicleOtherDetails ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DateReceivedByRepresentative", data.DateReceivedByRepresentative ?? (object)DBNull.Value);
                      

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"VehiclesAssigned saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveVehiclesAssigned: {ex.Message}");
                throw;
            }
        }
        public void SavePlanDetails(PlanDetailsData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO PlanDetails (CustomerID, PlanHolderName, PlanNo, Company, PlanType) 
                VALUES (@CustomerID, @PlanHolderName, @PlanNo, @Company, @PlanType)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@PlanHolderName", data.PlanHolderName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PlanNo", data.PlanNo ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Company", data.Company ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PlanType", data.PlanType ?? (object)DBNull.Value);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"PlanDetails saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SavePlanDetails: {ex.Message}");
                throw;
            }
        }
        public void SaveRegularPaymentDetails(PaymentDetailsData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    INSERT INTO RegularPaymentDetails 
                    (CustomerID, GrossPrice, PlanValue, ExtraCharges, Discount, ContractPrice, VAT, VATableSales) 
                    VALUES 
                    (@CustomerID, @GrossPrice, @PlanValue, @ExtraCharges, @Discount, @ContractPrice, @VAT, @VATableSales)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@GrossPrice", data.GrossPrice);
                        command.Parameters.AddWithValue("@PlanValue", data.PlanValue);
                        command.Parameters.AddWithValue("@ExtraCharges", data.ExtraCharges);
                        command.Parameters.AddWithValue("@Discount", data.Discount);
                        command.Parameters.AddWithValue("@ContractPrice", data.ContractPrice);
                        command.Parameters.AddWithValue("@VAT", data.VAT);
                        command.Parameters.AddWithValue("@VATableSales", data.VATableSales);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Console.WriteLine($"RegularPaymentDetails saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveRegularPaymentDetails: {ex.Message}");
                throw;
            }
        }
        public void SaveSeniorPaymentDetails(SeniorPaymentDetailsData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
            INSERT INTO SeniorPaymentDetails 
            (CustomerID, GrossPrice, PlanValue, ExtraCharges, SCDiscount, AdditionalDiscount, TotalVATExempt, ContractPrice) 
            VALUES 
            (@CustomerID, @GrossPrice, @PlanValue, @ExtraCharges, @SCDiscount, @AdditionalDiscount, @TotalVATExempt, @ContractPrice)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@GrossPrice", data.GrossPrice);
                        command.Parameters.AddWithValue("@PlanValue", data.PlanValue);
                        command.Parameters.AddWithValue("@ExtraCharges", data.ExtraCharges);
                        command.Parameters.AddWithValue("@SCDiscount", data.SCDiscount);
                        command.Parameters.AddWithValue("@AdditionalDiscount", data.AdditionalDiscount);
                        command.Parameters.AddWithValue("@TotalVATExempt", data.TotalVATExempt);
                        command.Parameters.AddWithValue("@ContractPrice", data.ContractPrice);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Console.WriteLine($"SeniorPaymentDetails saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveSeniorPaymentDetails: {ex.Message}");
                throw;
            }
        }
        public void SaveRepresentativeInfo(RepresentativeInfoData data)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    INSERT INTO RepresentativeInfo 
                    (CustomerID, PrimaryName, PrimaryRelationship, PrimaryAddress, PrimaryTelMobile, PrimaryEmail, PrimaryDate,
                    SecondaryName, SecondaryRelationship, SecondaryAddress, SecondaryTelMobile, SecondaryEmail, SecondaryDate) 
                    VALUES 
                    (@CustomerID, @PrimaryName, @PrimaryRelationship, @PrimaryAddress, @PrimaryTelMobile, @PrimaryEmail, @PrimaryDate,
                    @SecondaryName, @SecondaryRelationship, @SecondaryAddress, @SecondaryTelMobile, @SecondaryEmail, @SecondaryDate)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", data.CustomerID);
                        command.Parameters.AddWithValue("@PrimaryName", data.PrimaryName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PrimaryRelationship", data.PrimaryRelationship ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PrimaryAddress", data.PrimaryAddress ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PrimaryTelMobile", data.PrimaryTelMobile ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PrimaryEmail", data.PrimaryEmail ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@PrimaryDate", data.PrimaryDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryName", data.SecondaryName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryRelationship", data.SecondaryRelationship ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryAddress", data.SecondaryAddress ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryTelMobile", data.SecondaryTelMobile ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryEmail", data.SecondaryEmail ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SecondaryDate", data.SecondaryDate ?? (object)DBNull.Value);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"RepresentativeInfo saved for CustomerID: {data.CustomerID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveRepresentativeInfo: {ex.Message}");
                throw;
            }
        }

    }
}
