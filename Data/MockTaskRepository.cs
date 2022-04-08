using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Data
{
    public class MockTaskRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        private readonly IDayRepository _dayRepository = new MockDayRepository();
        public IEnumerable<Item> AllItems => 
            new List<Item>
            {
                new Item { Id = 1, Category = _categoryRepository.AllCategories.ToList()[0], SubCategory = _categoryRepository.AllCategories.ToList()[0].SubCategories.ToList()[0], Date = _dayRepository.AllDays.ToList()[1].Date, Time = 30 },
                new Item { Id = 2, Category = _categoryRepository.AllCategories.ToList()[0], SubCategory = _categoryRepository.AllCategories.ToList()[0].SubCategories.ToList()[1], Date = _dayRepository.AllDays.ToList()[0].Date, Time = 30 },
                new Item { Id = 3, Category = _categoryRepository.AllCategories.ToList()[1], SubCategory = _categoryRepository.AllCategories.ToList()[1].SubCategories.ToList()[0], Date = _dayRepository.AllDays.ToList()[1].Date, Time = 20 },
                new Item { Id = 4, Category = _categoryRepository.AllCategories.ToList()[1], SubCategory = _categoryRepository.AllCategories.ToList()[1].SubCategories.ToList()[1], Date = _dayRepository.AllDays.ToList()[0].Date, Time = 15 }
            };

        public Item GetItemById(int id)
        {
            return AllItems.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Item> GetItemsByCategory(Category category)
        {
            return AllItems.Where(c => c.Category == category);
        }
    }
}
