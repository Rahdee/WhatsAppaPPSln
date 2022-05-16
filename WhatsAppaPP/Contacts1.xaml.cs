using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsAppaPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts1 : ContentPage
    {
        private List<Contact> _contacts = new List<Contact>();

        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
            

        public Contacts1()
        {
            InitializeComponent();

            GenerateContracts();

            BindingContext = this;

        }

        private void GenerateContracts()
        {
            var contact = new Contact();
            contact.FullName = "Angel Adams";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "074 463 1794";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Bonolo Mbekhi";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "063 467 1254";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Britney Petersen";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "061 645 0901";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Chleo Adams";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "064 024 5678";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Cloe Petersen";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "075 897 1458";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Dominique Harris";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "065 890 1475";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Kayla Marcus";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "061 545 8702";

            Contacts.Add(contact);
                                                                
            contact = new Contact(); 
            contact.FullName = "Lauren Peters";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "067 645 1951";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Mariam Johnson";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "061 445 5902";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Marilyn Paul";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "067 245 8901";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Meisha Peters";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "064 024 5678";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Pan Smith";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "071 097 2453";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Robyn Davids";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "062 390 5475";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Sam Jameson";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "071 448 8712";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Tarryn Harris";
            contact.ProfileImageName = "stuff.png";
            contact.PhoneNumber = "068 255 1151";


        }

    }
}