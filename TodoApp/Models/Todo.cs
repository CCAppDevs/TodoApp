using System.Diagnostics.CodeAnalysis;

namespace TodoApp.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
    }
}
