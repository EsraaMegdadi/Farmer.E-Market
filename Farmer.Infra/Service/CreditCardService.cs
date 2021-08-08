using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class CreditCardService:ICreditCardService
    {
        private readonly ICreditCardRepository CreditCardRepository;
        public CreditCardService(ICreditCardRepository creditCardRepository)
        {
            CreditCardRepository = creditCardRepository;

        }
        public List<CreditCard> GetAll()
        {
            return CreditCardRepository.GetAll();
        }

        public CreditCard Create(CreditCard creditCard)
        {
            CreditCardRepository.Create(creditCard);
            return new CreditCard();
        }

        public CreditCard Update(CreditCard creditCard)
        {
            CreditCardRepository.Update(creditCard);
            return new CreditCard();
        }

        public CreditCard Delete(int id)
        {
            CreditCardRepository.Delete(id);
            return new CreditCard();
        }

    }
}
