using System;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu
{
    public class MainMenu
    {
        public void Run()
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("      HEALTH CLINIC SYSTEM");
                Console.WriteLine("");
                Console.WriteLine("Press 1 : Handle Patients");
                Console.WriteLine("Press 2 : Handle Doctors");
                Console.WriteLine("Press 3 : Handle Appointments");
                Console.WriteLine("Press 4 : Handle Rooms");
                Console.WriteLine("Press 5 : Exit");
                Console.Write("\nEnter Your Choice : ");

                string c = Console.ReadLine() ?? "";

                switch (c)
                {
                    case "1":
                        HandlePatient();
                        break;

                    case "2":
                        HandleDoctor();
                        break;

                    case "3":
                        HandleAppointment();
                        break;

                    case "4":
                        HandleRoom();
                        break;

                    case "5":
                        back = true;
                        Console.WriteLine("\nThank You!");
                        break;

                    default:
                        Console.WriteLine("\nWrong Choice!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // ================= Patient Menu =================

        public static void HandlePatient()
        {
            PatientService patient = new PatientService();

            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("PATIENT MENU ");
                Console.WriteLine("Press 1 : Add Patient");
                Console.WriteLine("Press 2 : Update Patient");
                Console.WriteLine("Press 3 : Delete Patient");
                Console.WriteLine("Press 4 : View All Patients");
                Console.WriteLine("Press 5 : Back");
                Console.Write("\nEnter Your Choice : ");

                string c = Console.ReadLine() ?? "";

                switch (c)
                {
                    case "1":
                        patient.AddPatient();
                        break;

                    case "2":
                        patient.UpdatePatient();
                        break;

                    case "3":
                        patient.DeletePatient();
                        break;

                    case "4":
                        patient.ShowAllPatients();
                        break;

                    case "5":
                        back = true;
                        break;

                    default:
                        Console.WriteLine("\nWrong Choice!");
                        break;
                }

                if (!back)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        // ================= Doctor Menu =================

        public static void HandleDoctor()
        {
            DoctorService doctor = new DoctorService();

            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("DOCTOR MENU ");
                Console.WriteLine("Press 1 : Add Doctor");
                Console.WriteLine("Press 2 : Update Doctor");
                Console.WriteLine("Press 3 : Delete Doctor");
                Console.WriteLine("Press 4 : View All Doctors");
                Console.WriteLine("Press 5 : Back");
                Console.Write("\nEnter Your Choice : ");

                string c = Console.ReadLine() ?? "";

                switch (c)
                {
                    case "1":
                        doctor.AddDoctor();
                        break;

                    case "2":
                        doctor.UpdateDoctor();
                        break;

                    case "3":
                        doctor.DeleteDoctor();
                        break;

                    case "4":
                        doctor.ShowAllDoctors();
                        break;

                    case "5":
                        back = true;
                        break;

                    default:
                        Console.WriteLine("\nWrong Choice!");
                        break;
                }

                if (!back)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        // ================= Appointment Menu =================

        public static void HandleAppointment()
        {
            AppointmentService appointment = new AppointmentService();

            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine(" APPOINTMENT MENU ");
                Console.WriteLine("Press 1 : Add Appointment");
                Console.WriteLine("Press 2 : Update Appointment");
                Console.WriteLine("Press 3 : Delete Appointment");
                Console.WriteLine("Press 4 : View All Appointments");
                Console.WriteLine("Press 5 : Back");
                Console.Write("\nEnter Your Choice : ");

                string c = Console.ReadLine() ?? "";

                switch (c)
                {
                    case "1":
                        appointment.AddAppointment();
                        break;

                    case "2":
                        appointment.UpdateAppointment();
                        break;

                    case "3":
                        appointment.DeleteAppointment();
                        break;

                    case "4":
                        appointment.ShowAllAppointments();
                        break;

                    case "5":
                        back = true;
                        break;

                    default:
                        Console.WriteLine("\nWrong Choice!");
                        break;
                }

                if (!back)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        // ================= Room Menu =================

        public static void HandleRoom()
        {
            RoomService room = new RoomService();

            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine(" ROOM MENU ");
                Console.WriteLine("Press 1 : Add Room");
                Console.WriteLine("Press 2 : Update Room");
                Console.WriteLine("Press 3 : Delete Room");
                Console.WriteLine("Press 4 : View All Rooms");
                Console.WriteLine("Press 5 : Back");
                Console.Write("\nEnter Your Choice : ");

                string c = Console.ReadLine() ?? "";

                switch (c)
                {
                    case "1":
                        room.AddRoom();
                        break;

                    case "2":
                        room.UpdateRoom();
                        break;

                    case "3":
                        room.DeleteRoom();
                        break;

                    case "4":
                        room.ShowAllRooms();
                        break;

                    case "5":
                        back = true;
                        break;

                    default:
                        Console.WriteLine("\nWrong Choice!");
                        break;
                }

                if (!back)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}