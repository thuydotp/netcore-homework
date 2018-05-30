using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleBlog.Models.BlogViewModels;
using SimpleBlog.Persistence;
using AutoMapper;

namespace SimpleBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly SimpleBlogContext _context;
        private readonly IMapper _mapper;

        public CategoryController(SimpleBlogContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: CategoryViewModels
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Category.ToListAsync();
            List<CategoryViewModel> categoryViewModels = _mapper.Map<List<Category>, List<CategoryViewModel>>(categories);
            return View(categoryViewModels);
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _context.Category.SingleOrDefaultAsync(m => m.Id == id);
            CategoryViewModel categoryViewModel = _mapper.Map<Category, CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return NotFound();
            }

            return View(categoryViewModel);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                categoryViewModel.Id = Guid.NewGuid();
                Category model = _mapper.Map<CategoryViewModel,Category>(categoryViewModel);                
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryViewModel);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _context.Category.SingleOrDefaultAsync(m => m.Id == id);
            CategoryViewModel categoryViewModel = _mapper.Map<Category,CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return NotFound();
            }
            return View(categoryViewModel);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description")] CategoryViewModel categoryViewModel)
        {
            if (id != categoryViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Category model = _mapper.Map<CategoryViewModel, Category>(categoryViewModel);
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryViewModelExists(categoryViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoryViewModel);
        }

        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Category category = await _context.Category.SingleOrDefaultAsync(m => m.Id == id);
            CategoryViewModel categoryViewModel = _mapper.Map<Category,CategoryViewModel>(category);

            if (categoryViewModel == null)
            {
                return NotFound();
            }

            return View(categoryViewModel);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            Category category = await _context.Category.SingleOrDefaultAsync(m => m.Id == id);
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryViewModelExists(Guid id)
        {
            return _context.Category.Any(e => e.Id == id);
        }
    }
}
