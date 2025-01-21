using EvaluacionP3TomasLopez.ModelsTLopez;
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
			var paisGuardar = new PaisDB
			{
				Name = paisEncontrado.Name.Official,
				Region = paisEncontrado.Region,
				Maps = paisEncontrado.Maps.GoogleMaps,
				TLopez = "TLopez"

			};

			await _basePaises.GuardarPais(paisGuardar);
			BindingContext=paisGuardar;
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		PaisFront.Text=null;
    }
}