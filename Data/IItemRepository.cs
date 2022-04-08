using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Data
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        IEnumerable<Item> GetItemsByCategory(Category category);
        // Get tasks by date
        // Get tasks by subcategory

        Item GetItemById(int id);
    }
}
