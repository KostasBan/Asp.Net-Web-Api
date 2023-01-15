using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactController : ApiController
    {
        //// GET: Contact
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Dan Roth"
                }
             };
        }
    }
}