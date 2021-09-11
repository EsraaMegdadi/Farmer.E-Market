using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class ContactUsService:IContactUsService
    {
        private readonly IContactUsRepository ContactUsRepository;
        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            ContactUsRepository = contactUsRepository;

        }
        public List<ContactUs> GetAll()
        {
            return ContactUsRepository.GetAll();
        }
        public ContactUs GetById(int id)
        {
            return ContactUsRepository.GetById(id);
        }
        public ContactUs Create(ContactUs contactUs)
        {
            ContactUsRepository.Create(contactUs);
            return new ContactUs();
        }

        public ContactUs Update(ContactUs contactUs)
        {
            ContactUsRepository.Update(contactUs);
            return new ContactUs();
        }

        public ContactUs Delete(int id)
        {
            ContactUsRepository.Delete(id);
            return new ContactUs();
        }
    }
}
