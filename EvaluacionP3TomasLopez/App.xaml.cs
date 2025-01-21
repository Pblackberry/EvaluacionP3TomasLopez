using EvaluacionP3TomasLopez.ViewsTLopez;

namespace EvaluacionP3TomasLopez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new PaginaBusqueda();
        }
       
    }
}