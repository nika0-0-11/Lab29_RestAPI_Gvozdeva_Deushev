namespace TaskApi.Models;

public class UpdateTskDto
{
    partial string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public string Priority { get; set; } = "Normal";
}