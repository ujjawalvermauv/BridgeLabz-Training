namespace FundooNotes.Models.Entities;

public class Reminder
{
    public int Id { get; set; }
    public int NoteId { get; set; }
    public int UserId { get; set; }
    public DateTime ReminderTime { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = null!;
    public Note Note { get; set; } = null!;
}
