using System;
using System.Data;
using HealthClinicApp.Data;
using HealthClinicApp.Entities;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
    public class PatientService
    {
        private readonly string connectionString;

        // Constructor
        public PatientService()
        {
            connectionString = DbConnection.GetDbConnection();
        }

        // Add new patient using Normal SQL Query (Connected Architecture)
        public void AddPatient()
        {
            Patient patient = new Patient();

            Console.Write("Enter Patient Name : ");
            patient.Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Gender : ");
            patient.Gender = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Date of Birth (yyyy-mm-dd) : ");
            patient.DateOfBirth = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Phone : ");
            patient.Phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Email : ");
            patient.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Address : ");
            patient.Address = Console.ReadLine() ?? string.Empty;

            string query = @"INSERT INTO Patient
                            (Name, Gender, Date_Of_Birth, Phone, Email, Address)
                            VALUES
                            (@Name, @Gender, @DateOfBirth, @Phone, @Email, @Address)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("\nPatient Added Successfully.");
                else
                    Console.WriteLine("\nFailed to Add Patient.");
            }
        }

        // Update Patient using Connected Architecture
        public void UpdatePatient()
        {
            Console.Write("Enter Patient ID : ");
            int patientId = int.Parse(Console.ReadLine() ?? "0");

            Patient patient = new Patient();

            Console.Write("Enter Patient Name : ");
            patient.Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Gender : ");
            patient.Gender = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Date of Birth (yyyy-mm-dd) : ");
            patient.DateOfBirth = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Phone : ");
            patient.Phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Email : ");
            patient.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Address : ");
            patient.Address = Console.ReadLine() ?? string.Empty;

            string query = @"UPDATE Patient
                             SET Name=@Name,
                                 Gender=@Gender,
                                 Date_Of_Birth=@DateOfBirth,
                                 Phone=@Phone,
                                 Email=@Email,
                                 Address=@Address
                             WHERE Patient_ID=@PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("\nPatient Updated Successfully.");
                else
                    Console.WriteLine("\nPatient Not Found.");
            }
        }

        // Delete Patient using Connected Architecture
        public void DeletePatient()
        {
            try
            {
                Console.Write("Enter Patient ID : ");
                int patientId = int.Parse(Console.ReadLine() ?? "0");

                string query = "DELETE FROM Patient WHERE Patient_ID=@PatientID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@PatientID", patientId);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        Console.WriteLine("\nPatient Deleted Successfully.");
                    else
                        Console.WriteLine("\nPatient Not Found.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Console.WriteLine("\nCannot delete patient because appointments exist for this patient.");
                }
                else
                {
                    Console.WriteLine($"\nDatabase Error : {ex.Message}");
                }
            }
        }

        // Display all patients using Disconnected Architecture
        public void ShowAllPatients()
        {
            string query = "SELECT * FROM Patient";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("\nNo Patients Found.");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"Patient ID    : {row["Patient_ID"]}");
                    Console.WriteLine($"Name          : {row["Name"]}");
                    Console.WriteLine($"Gender        : {row["Gender"]}");
                    Console.WriteLine($"Date Of Birth : {Convert.ToDateTime(row["Date_Of_Birth"]).ToShortDateString()}");
                    Console.WriteLine($"Phone         : {row["Phone"]}");
                    Console.WriteLine($"Email         : {row["Email"]}");
                    Console.WriteLine($"Address       : {row["Address"]}");
                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}