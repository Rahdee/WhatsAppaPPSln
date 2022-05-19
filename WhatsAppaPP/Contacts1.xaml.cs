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
        public class ScrollBarColorEffect : RoutingEffect
        {
            public ScrollBarColorEffect() : base($"MPlay.{nameof(ScrollBarColorEffect)}") { }

            public Color ScrollBarColor { get; set; }
        }
        private void GenerateContracts()
        {
            var contact = new Contact();
            contact.FullName = "Andre Adams";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "074 463 1794";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Bonolo Mbekhi";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "063 467 1254";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Britney Petersen";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "061 645 0901";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Chad Adams";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "064 024 5678";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Cloe Petersen";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "075 897 1458";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Dominique Harris";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "065 890 1475";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Kayla Marcus";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "061 545 8702";

            Contacts.Add(contact);
                                                                
            contact = new Contact(); 
            contact.FullName = "Lauren Peters";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "067 645 1951";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Mariam Johnson";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "061 445 5902";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Marvin Paul";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "067 245 8901";

            Contacts.Add(contact);

            contact = new Contact(); 
            contact.FullName = "Meisha Peters";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "064 024 5678";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Peter Smith";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "071 097 2453";

            Contacts.Add(contact); 

            contact = new Contact();
            contact.FullName = "Robyn Davids";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "062 390 5475";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Sam Jameson";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "071 448 8712";

            Contacts.Add(contact);

            contact = new Contact();
            contact.FullName = "Tarryn Harris";
            contact.ProfileImageName = "Contacticon1.png";
            contact.PhoneNumber = "068 255 1151";


        }

        private void ListView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsideContactPage1());
        }
    }
}