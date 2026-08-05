using System;
using HealthClinicApp.Data;
using HealthClinicApp.Entities;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
    public class RoomService
    {
        // Add new room
        public void AddRoom()
        {
            Room room = new Room();

            Console.Write("Enter Room Number : ");
            room.RoomNumber = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Floor Number : ");
            room.FloorNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Room Type : ");
            room.RoomType = Console.ReadLine() ?? string.Empty;

            // SQL Insert Query
            string query = @"INSERT INTO Rooms
                            (Room_Number, Floor_No, Room_Type)
                            VALUES
                            (@RoomNumber, @FloorNumber, @RoomType)";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Pass Parameters
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@FloorNumber", room.FloorNumber);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nRoom Added Successfully.");
                }
                else
                {
                    Console.WriteLine("\nFailed to Add Room.");
                }
            }
        }
                // Update room
        public void UpdateRoom()
        {
            Console.Write("Enter Room ID : ");
            int roomId = int.Parse(Console.ReadLine() ?? "0");

            Room room = new Room();

            Console.Write("Enter Room Number : ");
            room.RoomNumber = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Floor Number : ");
            room.FloorNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Room Type : ");
            room.RoomType = Console.ReadLine() ?? string.Empty;

            // SQL Update Query
            string query = @"UPDATE Rooms
                             SET Room_Number=@RoomNumber,
                                 Floor_No=@FloorNumber,
                                 Room_Type=@RoomType
                             WHERE Room_ID=@RoomID";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RoomID", roomId);
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@FloorNumber", room.FloorNumber);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nRoom Updated Successfully.");
                }
                else
                {
                    Console.WriteLine("\nRoom Not Found.");
                }
            }
        }
                // Delete room
        public void DeleteRoom()
{
    try
    {
        Console.Write("Enter Room ID : ");
        int roomId = int.Parse(Console.ReadLine() ?? "0");

        string query = "DELETE FROM Rooms WHERE Room_ID = @RoomID";

        string str = DbConnection.GetDbConnection();

        using (SqlConnection conn = new SqlConnection(str))
        {
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@RoomID", roomId);

            conn.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("\nRoom Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("\nRoom Not Found.");
            }
        }
    }
    catch (SqlException ex)
    {
        if (ex.Number == 547)
        {
            Console.WriteLine("\nCannot delete room because it is assigned to a doctor.");
        }
        else
        {
            Console.WriteLine($"\nDatabase Error: {ex.Message}");
        }
    }
}        public void ShowAllRooms()
        {
            string query = "SELECT * FROM Rooms";

            string str = DbConnection.GetDbConnection();

            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("\nNo Rooms Found.");
                        return;
                    }

                    while (reader.Read())
                    {
                        
                        Console.WriteLine($"Room ID     : {reader["Room_ID"]}");
                        Console.WriteLine($"Room Number : {reader["Room_Number"]}");
                        Console.WriteLine($"Floor No    : {reader["Floor_No"]}");
                        Console.WriteLine($"Room Type   : {reader["Room_Type"]}");
                        
                    }
                }
            }
        }
    }
}