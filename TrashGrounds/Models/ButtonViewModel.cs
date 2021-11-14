namespace TrashGrounds.Models
{
    public class ButtonViewModel
    {
        public ButtonViewModel(string type, string text, string size)
        {
            Type = type;
            Text = text;
            Size = size;
        }

        public string Type { get; set; } = "primary";

        public string Text { get; set; } = "";

        public string Size { get; set; } = "large";
    }
}