using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskTracker.Models
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Item> Items { get; set; }
    }
}
