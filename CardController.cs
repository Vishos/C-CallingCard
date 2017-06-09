using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace CallingCard.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Root()
        {
            return "This is the index!";
        }

        [HttpGet]
        [Route("index/{fname}/{lname}/{age}/{fcolor}")]
        public JsonResult Calling(string fname, string lname, int age, string fcolor)
        {
            var AnnonObj = new{
                FirstName = fname,
                LastName = lname,
                Age = age,
                FavoriteColor = fcolor
            };
            return Json(AnnonObj);
            
        }
    }
}