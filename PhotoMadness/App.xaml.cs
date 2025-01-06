using PhotoMadness.Repositories;
namespace PhotoMadness
{
    public partial class App : Application
    {
        public static RoleRepository? RoleRepo {  get; private set; }
        public App(RoleRepository roleRepo)
        {
            InitializeComponent();

            RoleRepo = roleRepo;
            MainPage = new NavigationPage(new MainPage());
        }

    }
}