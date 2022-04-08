using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Data
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Mandarin", SubCategories = 
                    new List<SubCategory>
                    {
                        new SubCategory { SubCategoryId = 1, SubCategoryName = "Listening" },
                        new SubCategory { SubCategoryId = 2, SubCategoryName = "Speaking" },
                        new SubCategory { SubCategoryId = 3, SubCategoryName = "Writing" },
                        new SubCategory { SubCategoryId = 4, SubCategoryName = "Reading" }
                    }
                },
                new Category { CategoryId = 2, CategoryName = "Programming", SubCategories = 
                    new List<SubCategory>
                    {
                        new SubCategory { SubCategoryId = 5, SubCategoryName = "Pluralsight" },
                        new SubCategory { SubCategoryId = 5, SubCategoryName = "Project" },
                        new SubCategory { SubCategoryId = 5, SubCategoryName = "Reading" },
                    }
                }
            };
    }
}
