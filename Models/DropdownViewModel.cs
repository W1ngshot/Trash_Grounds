using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace TrashGrounds.Models
{
    public class DropdownViewModel
    {
        public DropdownViewModel(string label, IEnumerable<DropdownOption> dropdownOptions)
        {
            Label = label;
            DropdownOptions = dropdownOptions;
        }
        
        public string Label { get; set; } = "";
        
        public IEnumerable<DropdownOption> DropdownOptions { get; set; }
        
    }

    public class DropdownOption
    {
        public DropdownOption(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        public string Name { get; set; }
        
        public string Value { get; set; }
    }
}