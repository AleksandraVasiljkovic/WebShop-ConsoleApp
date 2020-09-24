using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class ContactEFData : IContactData
    {
        public void InsertContact(ContactModel contactModel)
        {
            using (var context = new WebShopContext())
            {
                context.ContactModel.Add(contactModel);
                context.SaveChanges();
            }
        }
    }
}
