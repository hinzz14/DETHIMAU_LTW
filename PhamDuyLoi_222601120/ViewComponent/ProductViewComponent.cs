using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PhamDuyLoi_222601120.Models;

namespace PhamDuyLoi_222601120.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public ProductViewComponent(QlhangHoaContext context) 
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var listhh = _context.HangHoas.Where(h => h.Gia >= 100).ToList();
            return View("RenderProduct", listhh);
        }
    }
}
