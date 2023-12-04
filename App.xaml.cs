using Wisdom.Resources.Views;

namespace Wisdom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
            Routing.RegisterRoute(nameof(AddContactsPage),typeof(AddContactsPage));
            Routing.RegisterRoute(nameof(EditContactsPage), typeof(EditContactsPage));


            MainPage = new AppShell();
        }
    }
}
