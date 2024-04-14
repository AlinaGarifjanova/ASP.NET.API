using Infrastructure.Data.Entities;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factories
{
    public class ContactFactory
    {
        public static ContactEntity Create(ContactRegistrationForm form)
        {
            try
            {
                return new ContactEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = form.
                    Email = form.Email,
                    Message = form.Message,
                    HiddenSelectInput = form.HiddenSelectInput,

                };

            }catch (Exception ex) { }
            return null!;
        }

        public static Contact Create(ContactEntity entity) 
        {
            try
            {
                return new Contact
                {
                    //Id= entity.Id,
                    FullName = entity.FullName,
                    Email = entity.Email,
                    Message = entity.Message,
                    HiddenSelectInput = entity.HiddenSelectInput,
                };

            }
            catch { }
            return null!;
        }

        public static ContactEntity Create(ContactRegistrationForm form, int OptionId)
        {
            try
            {
                return new ContactEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = form.FullName,
                    Email = form.Email,
                    Message = form.Message,

                };

            }
            catch (Exception ex) { }
            return null!;
        }
        public static IEnumerable<Contact> Create(List<ContactEntity> entities)
        {
           var contacts = new List<Contact>();
            try{

                foreach( var entity in entities)
                    contacts.Add(Create(entity));
            }catch (Exception ex) { }
            return contacts;
        }
    }
}
