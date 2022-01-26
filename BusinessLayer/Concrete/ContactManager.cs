using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact contact)
        {
            if (contact.Mail == "" || contact.Message == "" || contact.Name == "" || contact.Subject == "" || contact.SurName == "" || contact.Mail.Length <= 10 || contact.Subject.Length <= 3)
            {
                return -1;
            }
            return repocontact.Insert(contact);
        }
        public List<Contact> GetAll()
        {
            return repocontact.List();
        }
        public Contact GetContactDetails(int id)
        {
            return repocontact.Find(x => x.ContactID == id);
        }
    }
}
