namespace TrashGrounds.Models;

public class TrackCardModel
{
    public long TrackId { get; set; } = 0;
    public string TrackName { get; set; } = nameof(TrackName);
    public long AuthorId { get; set; } = 0;
    public string AuthorName { get; set; } = nameof(AuthorName);
    public string? PreviewUrl { get; set; }
    public double Rating { get; set; } = 0;
}
