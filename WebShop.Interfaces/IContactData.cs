using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IContactData
    {
        void InsertContact(ContactModel contactModel);
    }
}
