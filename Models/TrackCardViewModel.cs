namespace TrashGrounds.Models
{

    public class TrackCardViewModel
    {
        public long TrackId { get; set; } = 0;
        public string TrackName { get; set; } = nameof(TrackName);
        public long AuthorId { get; set; } = 0;
        public string AuthorName { get; set; } = nameof(AuthorName);
        public string? PreviewUrl { get; set; }
        public string? Rating { get; set; }
    }
}