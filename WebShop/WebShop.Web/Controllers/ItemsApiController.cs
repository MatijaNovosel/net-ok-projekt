using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vjezba.DAL;
using WebShop.Model;
using WebShop.Web.Models.DTO;

namespace WebShop.Web.Controllers
{
    [Route("/api/items")]
    [ApiController]
    public class ItemsApiController : ControllerBase
    {
        private readonly WebShopDbContext _context;

        public ItemsApiController(WebShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems()
        {
            return await _context.Items.Include(x => x.Tags).Select(x => new ItemDto
            {
                Description = x.Description,
                Discount = x.Discount,
                Id = x.Id,
                MadeAt = x.MadeAt,
                Name = x.Name,
                Price = x.Price,
                Tags = x.Tags.Select(x => new TagDto() { Description = x.Description, Id = x.Id }).ToList()
            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDto>> GetItem(int id)
        {
            var item = await _context.Items.Include(x => x.Tags).Select(x => new ItemDto
            {
                Description = x.Description,
                Discount = x.Discount,
                Id = x.Id,
                MadeAt = x.MadeAt,
                Name = x.Name,
                Price = x.Price,
                Tags = x.Tags.Select(x => new TagDto() { Description = x.Description, Id = x.Id }).ToList()
            }).FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPut]
        public async Task<IActionResult> PutItem(UpdateItemDto item)
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

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(CreateItemDto item)
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

            return CreatedAtAction("GetItem", new { id = newItem.Id }, newItem);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
