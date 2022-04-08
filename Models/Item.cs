using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public int Time { get; set; }
        public DateTime Date { get; set; }
    }
}
