using Newtonsoft.Json;
using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.DTO.AddCars;
using projetocarro.BFF.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projetocarro.BFF.Repositorios
{
    public class RepositoriesCars :  IRepositoriesCars
    {

        public RepositoriesCars()
        {
         
        }

        public AddCarsResponse Add(AddCarsRequest cars)
        {
            try
            {
                var client = new RestClient("https://localhost:5001/car");
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.POST);
                requestClient.AddHeader("Content-Type", "application/json");
                requestClient.AddParameter("application/json",JsonConvert.SerializeObject(cars), ParameterType.RequestBody);
                IRestResponse response = client.Execute(requestClient);
                var responseCars = JsonConvert.DeserializeObject<AddCarsResponse>(response.Content);
                Console.WriteLine(response.Content);
                return responseCars;
            }
            catch (Exception)
            {

               throw new System.Exception("Sistema indisponivel no momento, teste mais tarde");
            }
          
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

