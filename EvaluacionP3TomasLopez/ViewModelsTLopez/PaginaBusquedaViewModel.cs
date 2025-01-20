using EvaluacionP3TomasLopez.ModelsTLopez;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvaluacionP3TomasLopez.ViewModelsTLopez
{
    public class PaginaBusquedaViewModel : CambiosViewModel
    {
        //public event Action onGuardarPais;
        //private string _namePais;
        //private string _Resultado;
        //public string NamePais
        //{
        //    get => _namePais;
        //    set => SetProperty(ref _namePais, value);
        //}

        //public string Resultado
        //{
        //    get => _Resultado;
        //    set => SetProperty(ref _Resultado, value);
        //}

        //public Command EncontrarPaisCommand { get; }
        //public Command LimpiarSearchBarCommand {  get; }

        //public async Task EncontrarPais()
        //{
        //    if (string.IsNullOrWhiteSpace(NamePais))
        //    {
        //        Resultado = "No se ha ingresado ningun país";
        //        return;
        //    }

        //    var linkApi = $"https://restcountries.com/v3.1/name/{NamePais}?fields=name,region,maps";
        //    try
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            var respuesta = await httpClient.GetStringAsync(linkApi);
        //            var paisesList = JsonConvert.DeserializeObject<List<PaisAPI>>(respuesta);
        //            if (paisesList != null && paisesList.Count > 0)
        //            {
        //                var pais = paisesList.First();
        //                Resultado = $"Nombre: {pais.Name.Official}\nRegion: {pais.Region}\nLink Google Maps: {pais.Maps.GoogleMaps}";
        //                onGuardarPais?.Invoke();
        //            }
        //            else
        //            {
        //                Resultado = "No existe un país con ese nombre, porfavor ingrese otro";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Resultado = $"Error {e.Message}";
        //    }
        //}

        //private void GuardarPaisDB(PaisAPI pais)
        //{

        //}

        
        
    }
}
