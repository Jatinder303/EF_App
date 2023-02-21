using EF_App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_App.Data
{
   public class ContactContext :DbContext
    {
        public ContactContext() : base("name = ContactDBConnectionString")
        {

        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
