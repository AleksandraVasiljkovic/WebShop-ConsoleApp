using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Interfaces;
using WebShop.Data;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class ContactBsn
    {
        public IContactData contactData;
        public ContactBsn()
        {
            contactData = new ContactEFData();
        }
        public bool Insert(ContactModel contactModel)
        {
            try
            {
                contactData.InsertContact(contactModel);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
