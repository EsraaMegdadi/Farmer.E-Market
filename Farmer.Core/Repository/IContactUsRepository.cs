using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
  public  interface IContactUsRepository
    {
        List<ContactUs> GetAll();
        ContactUs Getbyid(int ContactUsId);
        int Create(ContactUs Data);
        int Update(ContactUs Data);
        int Delete(int id);
    }
}
