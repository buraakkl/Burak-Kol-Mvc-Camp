using Microsoft.AspNetCore.Mvc;
using Web.UI.Models;

namespace Web.UI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID= 1,
                    UserName = "Burak"
                },                new UserComment
                {
                    ID= 2,
                    UserName = "Ahmet"
                },                new UserComment
                {
                    ID= 3,
                    UserName = "Samet"
                }
            };
            return View(commentValues);
        }
    }
}
