namespace HealthClinicApp.Entities
{
    public class Room
    {
        public int RoomID { get; set; }

        public string RoomNumber { get; set; } = string.Empty;

        public int FloorNumber { get; set; }

        public string RoomType { get; set; } = string.Empty;
    }
}