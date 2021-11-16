namespace TrashGrounds.Models
{
    public class FileUploaderViewModel
    {
        public FileUploaderViewModel(string label, string description)
        {
            Label = label;
            Description = description;
        }

        public string Label { get; set; } = "";
        
        public string Description { get; set; } = "";
    }
}