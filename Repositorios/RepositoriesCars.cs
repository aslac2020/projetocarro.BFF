using Newtonsoft.Json;
using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.DTO.AddCars;
using projetocarro.BFF.DTO.DeleteCars;
using projetocarro.BFF.DTO.ReturnCarById;
using projetocarro.BFF.DTO.ReturnListCars;
using projetocarro.BFF.DTO.UpdateCars;
using projetocarro.BFF.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projetocarro.BFF.Repositorios
{
    public class RepositoriesCars : IRepositoriesCars
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
                requestClient.AddParameter("application/json", JsonConvert.SerializeObject(cars), ParameterType.RequestBody);
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

        public ReturnCarIdResponse GetById(int id)
        {
            var responseCars = new ReturnCarIdResponse();
            try
            {
                var client = new RestClient($"https://localhost:5001/car/{id}");
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.GET);
                requestClient.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(requestClient);
                responseCars = JsonConvert.DeserializeObject<ReturnCarIdResponse>(response.Content);
                return responseCars;
            }
            catch (System.Exception)
            {
                throw new System.Exception("Erro ao retornar a lista de carros !");
                return responseCars;
            }

        }

        public ReturnListCarsResponse GetListCars()
        {
            var returnListCars = new ReturnListCarsResponse();

            try
            {
                var client = new RestClient($"https://localhost:5001/car/");
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.GET);
                requestClient.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(requestClient);
                returnListCars = JsonConvert.DeserializeObject<ReturnListCarsResponse>(response.Content);
                return returnListCars;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(int id)
        {
            try
            {
                var client = new RestClient($"https://localhost:5001/car/{id}");
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.DELETE);
                requestClient.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(requestClient);
                var responseCars = JsonConvert.DeserializeObject<DeleteCarsResponse>(response.Content);
            }
            catch (Exception)
            {

                throw new System.Exception("Erro ao excluir o carro !");
            }
        }

        public int Update(Cars cars, int id)
        {
            var updateCars = new UpdateCarsResponse();

            try
            {
                var client = new RestClient($"https://localhost:5001/car/{id}");
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.PUT);
                requestClient.AddHeader("Content-Type", "application/json");
                requestClient.AddParameter("application/json", JsonConvert.SerializeObject(updateCars), ParameterType.RequestBody);
                IRestResponse response = client.Execute(requestClient);
                updateCars = JsonConvert.DeserializeObject<UpdateCarsResponse>(response.Content);
                return updateCars.id;
            }
            catch (Exception)
            {

                throw new System.Exception("Erro ao atualizar o carro !");
                return updateCars.id;
            }
        }
    }
}

