using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface IContactUsService
    {
        List<ContactUs> GetAll();
        ContactUs getbyid(int ContactUsId);
        ContactUs Create(ContactUs contact);
        ContactUs Update(ContactUs contact);
        ContactUs Delete(int id);
    }
}
