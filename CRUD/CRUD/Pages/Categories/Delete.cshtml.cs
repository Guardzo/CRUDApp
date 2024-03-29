using CRUD.Data;
using CRUD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }

        public async Task<IActionResult> OnPost(Category category)
        {

                var categoryFromDb = _db.Category.Find(category.Id);
                if(categoryFromDb != null)
                {
                    _db.Category.Remove(categoryFromDb);
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
            }

                
            return Page();
        }
    }
}
