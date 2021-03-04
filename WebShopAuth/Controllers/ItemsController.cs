using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShop.DAL;
using WebShop.Model;
using WebShop.Web.ViewModels;
using WebShop.Web.Models.DTO;
using Microsoft.AspNetCore.Authorization;

namespace WebShop.Web.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly WebShopDbContext _context;

        public ItemsController(WebShopDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }

        public async Task<IActionResult> Grid()
        {
            ItemsGridViewModel vm = new ItemsGridViewModel();
            vm.TagSelect = _context.Tags.Select(x => new SelectListItem { Selected = false, Text = x.Description, Value = x.Id.ToString() }).ToList();
            vm.Items = await _context.Items.Include(x => x.Tags).ToListAsync();
            return View(vm);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            CreateItemViewModel vm = new CreateItemViewModel
            {
                TagSelect = _context.Tags.Select(x => new SelectListItem { Selected = false, Text = x.Description, Value = x.Id.ToString() }).ToList()
            };
            return View(vm);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateItemDto item)
        {
            Item newItem = new Item()
            {
                Description = item.Description,
                Discount = item.Discount,
                MadeAt = item.MadeAt,
                Name = item.Name,
                Price = item.Price
            };

            newItem.Tags = new List<Tag>();

            foreach (var tagId in item.TagIds)
            {
                newItem.Tags.Add(_context.Tags.FirstOrDefault(x => x.Id == tagId));
            }

            _context.Items.Add(newItem);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var item = await _context
                .Items
                .Include(x => x.Tags)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            CreateItemViewModel vm = new CreateItemViewModel();

            vm.Item = new UpdateItemDto()
            {
                Description = item.Description,
                Discount = item.Discount,
                Id = item.Id,
                MadeAt = item.MadeAt,
                Name = item.Name,
                Price = item.Price,
                TagIds = item.Tags.Select(x => x.Id).ToList()
            };

            vm.TagSelect = _context.Tags.Select(x => new SelectListItem
            {
                Selected = vm.Item.TagIds.Contains(x.Id),
                Text = x.Description,
                Value = x.Id.ToString()
            }).ToList();

            return View(vm);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm]UpdateItemDto item)
        {
            if (!ItemExists(item.Id))
            {
                return NotFound();
            }

            Item foundItem = await _context.Items.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == item.Id);
            _context.Entry(foundItem).CurrentValues.SetValues(item);

            foundItem.Tags = new List<Tag>();

            foreach (var tagId in item.TagIds)
            {
                foundItem.Tags.Add(_context.Tags.FirstOrDefault(x => x.Id == tagId));
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int? id)
        {
            if (id == null)
            {
                return false;
            }

            return _context.Items.Any(e => e.Id == id);
        }
    }
}
