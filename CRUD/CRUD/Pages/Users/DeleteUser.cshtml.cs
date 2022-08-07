using CRUD.Data;
using CRUD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Users
{
    public class DeleteUserModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Mango_User mangoUser { get; set; }
        public DeleteUserModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
           mangoUser = _db.MangoUser.Find(id);
        }

        public async Task<IActionResult> OnPost(Mango_User mangoUser)
        {
            var userFromDb=_db.MangoUser.Find(mangoUser.Id);
            if (userFromDb != null)
            {
                _db.MangoUser.Remove(userFromDb);
                await _db.SaveChangesAsync();
                return RedirectToPage("User");
            }
            return Page();
        }
    }
}
