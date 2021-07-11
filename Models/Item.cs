using System;
using System.Runtime.InteropServices;

namespace TodoList.Models
{
    public class Item
    {
        // Primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Due { get; set; }
    }
}