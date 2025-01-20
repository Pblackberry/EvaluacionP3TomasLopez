using EvaluacionP3TomasLopez.ModelsTLopez;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionP3TomasLopez
{
    public class ApiRepository
    {
        public async Task<IEnumerable<PaisAPI>> DevuelvePaisAsync(string NamePais)
        {
            string linkApi = $"https://restcountries.com/v3.1/name/{NamePais}?fields=name,region,maps";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var respuesta = await client.GetAsync(linkApi);
                    var json = await respuesta.Content.ReadAsStringAsync();
                    List<PaisAPI> paises = JsonConvert.DeserializeObject<List<PaisAPI>>(json);
                    return paises;
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
        }
    }
}
        
    

        
    

        
            
        

        
        
        
        
    

