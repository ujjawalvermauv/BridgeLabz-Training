namespace HealthClinicApp.Entities
{
    public class AuditLog
    {
        public int AuditID { get; set; }

        public string TableName { get; set; }

        public string ActionType { get; set; }

        public int RecordID { get; set; }

        public DateTime ActionDate { get; set; }
    }
}