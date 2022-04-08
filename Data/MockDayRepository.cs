using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Data
{
    public class MockDayRepository : IDayRepository
    {
        private readonly IItemRepository _itemRepository = new MockTaskRepository();
        public IEnumerable<Day> AllDays => 
            new List<Day>
            {
                new Day { Id = 1, Date = new DateTime(2020,12,15), Items = _itemRepository.AllItems.ToList() },
                new Day { Id = 2, Date = new DateTime(2020,12,16), Items = _itemRepository.AllItems.ToList() }
            };
    }
}
