using Microsoft.AspNetCore.Mvc;

namespace ViewComponents.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("MyGridView");
        }
    }
}
