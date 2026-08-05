using System;
using HealthClinicApp.Data;
using HealthClinicApp.Entities;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
    public class AppointmentService
    {
        // Book a new appointment
        public void AddAppointment()
        {
            Appointment appointment = new Appointment();

            // Take input from user
            Console.Write("Enter Patient ID : ");
            appointment.PatientID = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Doctor ID : ");
            appointment.DoctorID = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Appointment Date (yyyy-mm-dd) : ");
            appointment.AppointmentDate = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Start Time (HH:mm:ss) : ");
            appointment.StartTime = TimeSpan.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter End Time (HH:mm:ss) : ");
            appointment.EndTime = TimeSpan.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Status : ");
            appointment.Status = Console.ReadLine() ?? string.Empty;

            // SQL Insert Query
            string query = @"INSERT INTO Appointment
                            (Patient_ID, Doctor_ID, Appointment_Date, Start_Time, End_Time, Status)
                            VALUES
                            (@PatientID, @DoctorID, @AppointmentDate, @StartTime, @EndTime, @Status)";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Pass Parameters
                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);
                cmd.Parameters.AddWithValue("@Status", appointment.Status);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nAppointment Booked Successfully.");
                }
                else
                {
                    Console.WriteLine("\nFailed to Book Appointment.");
                }
            }
        } // Update appointment using Normal SQL Query
        public void UpdateAppointment()
        {
            Console.Write("Enter Appointment ID : ");
            int appointmentId = int.Parse(Console.ReadLine() ?? "0");

            Appointment appointment = new Appointment();

            Console.Write("Enter Patient ID : ");
            appointment.PatientID = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Doctor ID : ");
            appointment.DoctorID = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Appointment Date (yyyy-mm-dd) : ");
            appointment.AppointmentDate = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Start Time (HH:mm:ss) : ");
            appointment.StartTime = TimeSpan.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter End Time (HH:mm:ss) : ");
            appointment.EndTime = TimeSpan.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Status : ");
            appointment.Status = Console.ReadLine() ?? string.Empty;

            // SQL Update Query
            string query = @"UPDATE Appointment
                            SET Patient_ID = @PatientID,
                                Doctor_ID = @DoctorID,
                                Appointment_Date = @AppointmentDate,
                                Start_Time = @StartTime,
                                End_Time = @EndTime,
                                Status = @Status
                            WHERE Appointment_ID = @AppointmentID";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Pass Parameters
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);
                cmd.Parameters.AddWithValue("@Status", appointment.Status);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nAppointment Updated Successfully.");
                }
                else
                {
                    Console.WriteLine("\nAppointment Not Found.");
                }
            }
        }
        // Delete appointment using Normal SQL Query
        public void DeleteAppointment()
        {
            Console.Write("Enter Appointment ID : ");
            int appointmentId = int.Parse(Console.ReadLine() ?? "0");

            string query = "DELETE FROM Appointment WHERE Appointment_ID = @AppointmentID";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Pass Parameter
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nAppointment Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("\nAppointment Not Found.");
                }
            }
        }
        // Display all appointments
        public void ShowAllAppointments()
        {
            string query = "SELECT * FROM Appointment";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("\nNo Appointments Found.");
                        return;
                    }

                    while (reader.Read())
                    {
                        
                        Console.WriteLine($"Appointment ID : {reader["Appointment_ID"]}");
                        Console.WriteLine($"Patient ID     : {reader["Patient_ID"]}");
                        Console.WriteLine($"Doctor ID      : {reader["Doctor_ID"]}");
                        Console.WriteLine($"Date           : {Convert.ToDateTime(reader["Appointment_Date"]).ToShortDateString()}");
                        Console.WriteLine($"Start Time     : {reader["Start_Time"]}");
                        Console.WriteLine($"End Time       : {reader["End_Time"]}");
                        Console.WriteLine($"Status         : {reader["Status"]}");
                        
                    }
                }
            }
        }
    }
}