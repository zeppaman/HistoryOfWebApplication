using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcSample.DAL;
using MvcSample.Models;

namespace MvcSample.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(string name, string email)
        {
            var contact = new Contact()
            {
                Email = email,
                Name = name
            };
            using (var db = new Database())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
            }

            return View("ContactSaved", contact);
        }
    }
}