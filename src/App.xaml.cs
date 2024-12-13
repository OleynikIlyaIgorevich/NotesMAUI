using NotesMAUI.DatabaseContext;

namespace NotesMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
        }
    }
}
