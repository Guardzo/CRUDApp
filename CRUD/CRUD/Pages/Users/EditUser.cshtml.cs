using CRUD.Data;
using CRUD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Users
{
    public class EditUserModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Mango_User mangoUser { get; set; }
        public EditUserModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
           mangoUser = _db.MangoUser.Find(id);
        }

        public async Task<IActionResult> OnPost(Mango_User mangoUser)
        {
            
            if (ModelState.IsValid)
            {
                _db.MangoUser.Update(mangoUser);
                await _db.SaveChangesAsync();
                return RedirectToPage("User");
            }
            return Page();
        }
    }
}
