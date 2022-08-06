using CRUD.Data;
using CRUD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Users
{
    public class UserModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Mango_User> MangoUser { get; set; }

        public UserModel(ApplicationDbContext db)
        {
            _db = db;
        }
 
        

        public void OnGet()
        {
            MangoUser = _db.MangoUser;
        }
    }
}
