using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Data;

namespace TaskTracker.Controllers
{
    public class DayController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDayRepository _dayRepository;

        public DayController(IItemRepository itemRepository, ICategoryRepository categoryRepository, IDayRepository dayRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
            _dayRepository = dayRepository;
        }

        //Get Item Controller
        public IActionResult List()
        {
            return View(_dayRepository.AllDays);
        }

        public IActionResult Detail(int id)
        {
            var day = _dayRepository.AllDays.FirstOrDefault(x => x.Id == id);
            if (day == null)
            {
                return NotFound();
            }
            return View(day);
        }
    }
}
