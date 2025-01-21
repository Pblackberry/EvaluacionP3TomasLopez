using EvaluacionP3TomasLopez.ModelsTLopez;
using System.Collections.ObjectModel;

namespace EvaluacionP3TomasLopez.ViewsTLopez;

public partial class PaginaPaisesLista : ContentPage
{
	ObservableCollection<PaisDB> paises;
	BasePaises _BasePaises;
	public PaginaPaisesLista()
	{
		InitializeComponent();
        MostrarPaises();
		
		 
	}

	public async void MostrarPaises()
	{
        string path = Path.Combine(FileSystem.AppDataDirectory, "Paises.db3");
        paises = new ObservableCollection<PaisDB>();
        _BasePaises = new BasePaises(path);
        List<PaisDB> listaPaises = new List<PaisDB>();
        listaPaises = await _BasePaises.GetAllPaises();
        paises = new ObservableCollection<PaisDB>(listaPaises);
		BindingContext = this;
    }

    public ObservableCollection<PaisDB> Paises { get { return paises; } set { paises = value; } }


}