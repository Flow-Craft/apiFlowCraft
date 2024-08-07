using ApiNet8.Models;
using ApiNet8.Models.Usuarios;
using ApiNet8.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiNet8.Controllers
{    
    public class CustomController : ControllerBase
    {
        [HttpGet]
        public CurrentUser GetCurrentUser() 
        {           
            return HttpContext.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
        }

        [HttpPost]
        public void SetCurrentUser(CurrentUser currentUser)
        {
            HttpContext.Session.SetObjectAsJson("CurrentUser", currentUser);
        }


    }
}
