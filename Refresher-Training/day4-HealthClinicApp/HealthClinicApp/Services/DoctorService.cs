using System;
using System.Data;
using HealthClinicApp.Data;
using HealthClinicApp.Entities;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
    public class DoctorService
    {
        // Insert new doctor using Stored Procedure
        public void AddDoctor()
        {
            Doctor doctor = new Doctor();

            // Take input from user
            Console.Write("Enter Doctor Name : ");
            doctor.Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Specialty : ");
            doctor.Specialty = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Phone : ");
            doctor.Phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Email : ");
            doctor.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Experience (Years) : ");
            doctor.ExperienceYears = int.Parse(Console.ReadLine() ?? "0");

            // Get Connection String
            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertDoctor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass parameters
                    cmd.Parameters.AddWithValue("@Name", doctor.Name);
                    cmd.Parameters.AddWithValue("@Specialty", doctor.Specialty);
                    cmd.Parameters.AddWithValue("@Phone", doctor.Phone);
                    cmd.Parameters.AddWithValue("@Email", doctor.Email);
                    cmd.Parameters.AddWithValue("@Experience_Years", doctor.ExperienceYears);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\nDoctor Added Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nFailed to Add Doctor.");
                    }
                }
            }
        }
                // Update doctor using Stored Procedure
        public void UpdateDoctor()
        {
            Console.Write("Enter Doctor ID : ");
            int doctorId = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter New Phone : ");
            string phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter New Email : ");
            string email = Console.ReadLine() ?? string.Empty;

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateDoctor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass parameters
                    cmd.Parameters.AddWithValue("@Doctor_ID", doctorId);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\nDoctor Updated Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nDoctor Not Found.");
                    }
                }
            }
        }
                // Delete doctor using Stored Procedure
        public void DeleteDoctor()
{
    try
    {
        Console.Write("Enter Doctor ID : ");
        int doctorId = int.Parse(Console.ReadLine() ?? "0");

        string str = DbConnection.GetDbConnection();

        using (SqlConnection conn = new SqlConnection(str))
        {
            using (SqlCommand cmd = new SqlCommand("sp_DeleteDoctor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Pass parameter
                cmd.Parameters.AddWithValue("@Doctor_ID", doctorId);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nDoctor Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("\nDoctor Not Found.");
                }
            }
        }
    }
    catch (SqlException ex)
    {
        if (ex.Number == 547)
        {
            Console.WriteLine("\nCannot delete doctor because appointments are assigned to this doctor.");
        }
        else
        {
            Console.WriteLine($"\nDatabase Error: {ex.Message}");
        }
    }
}
                // Display all doctors
        public void ShowAllDoctors()
        {
            string query = "SELECT * FROM Doctor";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("\nNo Doctors Found.");
                        return;
                    }

                    while (reader.Read())
                    {
                        
                        Console.WriteLine($"Doctor ID   : {reader["Doctor_ID"]}");
                        Console.WriteLine($"Name        : {reader["Name"]}");
                        Console.WriteLine($"Specialty   : {reader["Specialty"]}");
                        Console.WriteLine($"Phone       : {reader["Phone"]}");
                        Console.WriteLine($"Email       : {reader["Email"]}");
                        Console.WriteLine($"Experience  : {reader["Experience_Years"]} Years");
                        
                    }
                }
            }
        }
    }
}
    
