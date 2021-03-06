using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface ICreditCardService
    {
        List<CreditCard> GetAll();
        CreditCard GetById(int id);
        CreditCard Create(CreditCard CreditCard);
        CreditCard Update(CreditCard Data);
        CreditCard Delete(int Id);
    }
}
