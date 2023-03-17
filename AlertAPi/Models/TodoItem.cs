namespace AlertAPi.Models;

public class TodoItem
{
    public Guid Key { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; }
    public Guid OwnerKey { get; set; }
    public DateTime? Timestamp { get; set; }
}