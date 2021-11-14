namespace TrashGrounds.Models
{
    public class TextInputViewModel
    {
        public TextInputViewModel(string type, string label)
        {
            Type = type;
            Label = label;
        }

        public string Type { get; set; } = "primary";

        public string Label { get; set; } = "";
    }
}