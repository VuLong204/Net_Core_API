using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Data;
using FirstWebMVC.Models.Entities;
using System.Threading.Tasks;

namespace FirstWebMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // --- YÊU CẦU 2: HIỂN THỊ DỮ LIỆU ---
        public async Task<IActionResult> Index()
        {
            // Code của bạn tiếp tục ở đây...
            return View();
        }
    }
}