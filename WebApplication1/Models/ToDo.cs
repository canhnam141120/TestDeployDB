using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ToDo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
    }
}
