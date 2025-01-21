using System.Collections.ObjectModel;

namespace EvaluacionP3TomasLopez.ViewsTLopez;

public partial class PaginaBusqueda : ContentPage
{
	ApiRepository _paisApiRepository;
	BasePaises _basePaises;
	
	public PaginaBusqueda()
	{
		InitializeComponent();
		_paisApiRepository = new ApiRepository();
		string path = Path.Combine(FileSystem.AppDataDirectory, "Paises.db3");
		_basePaises= new BasePaises(path);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		string paisBusqueda = PaisFront.Text;
		var paisesList=(await _paisApiRepository.DevuelvePaisAsync(paisBusqueda)).ToList();
		var paisEncontrado=paisesList.FirstOrDefault();
		if (paisEncontrado != null) { 
			
		}
    }
}