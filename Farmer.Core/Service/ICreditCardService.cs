using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface ICreditCardService
    {
        List<CreditCard> GetAll();
        CreditCard getbyid(int CreditCardId);
        CreditCard Create(CreditCard CreditCard);
        CreditCard Update(CreditCard Data);
        CreditCard Delete(int Id);
    }
}
