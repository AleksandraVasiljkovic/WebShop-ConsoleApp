using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class ContactController: Controller
    {
        // POST: ProductController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/SaveContact/")]
        public bool Create([FromBody] ContactModel contactModel)
        {
            ContactBsn contactBsn = new ContactBsn();
            var result = contactBsn.Insert(contactModel);
            return result;
        }
    }
}
