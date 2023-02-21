using EF_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_App
{
    public partial class ContactDetails : Form
    {
        private ContactContext _context;
        public ContactDetails()
        {
            InitializeComponent();
            _context = new ContactContext();
            dataGridView1.DataSource = _context.Contacts.ToList();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Contact_Form contact_object = new Contact_Form();
            if(contact_object.ShowDialog() == DialogResult.OK)
            {
                _context.Contacts.Add(contact_object.Contact_obj);
                _context.SaveChanges();
                dataGridView1.DataSource = _context.Contacts.ToList();
            }
        }
    }
}
