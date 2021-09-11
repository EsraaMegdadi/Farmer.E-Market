using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
    public interface ICreditCardRepository
    {
        List<CreditCard> GetAll();
        CreditCard GetById(int id);
        int Create(CreditCard Data);
        int Update(CreditCard Data);
        int Delete(int Id);
    }
}
