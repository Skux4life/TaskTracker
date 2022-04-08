using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Data
{
    public interface IDayRepository
    {
        IEnumerable<Day> AllDays { get; }
        
        // get byid?
        // get by date or date range
    }
}
