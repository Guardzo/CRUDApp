using CRUD.Data;
using CRUD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Users
{
    public class CreateUserModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Mango_User mangoUser { get; set; }
        public CreateUserModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Mango_User mangoUser)
        {
            
            if (ModelState.IsValid)
            {
                await _db.MangoUser.AddAsync(mangoUser);
                await _db.SaveChangesAsync();
                return RedirectToPage("User");
            }
            return Page();
        }
    }
}
