namespace EvaluacionP3TomasLopez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public static string DatabasePath
        {
            get
            {
                var dbpath = Path.Combine(FileSystem.AppDataDirectory, "ExamenDBTomasLopez.db3");
                return dbpath;
            }
        }
       
    }
}