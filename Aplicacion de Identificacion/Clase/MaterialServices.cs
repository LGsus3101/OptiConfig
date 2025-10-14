using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json.Linq;


namespace Aplicacion_de_Identificacion.Clase
{
    internal class MaterialServices
    {
        private readonly GraphQLHttpClient _client;

        public MaterialServices(string endpoint)
        {
            _client = new GraphQLHttpClient(endpoint, new NewtonsoftJsonSerializer());
        }
        public async Task<string> ObtenerMaterialPorSerialAsync(string serial)
        {
            if (string.IsNullOrWhiteSpace(serial))
                throw new ArgumentException("El numero de serie no puede estar vacio.", nameof(serial));
            var request = new GraphQLRequest
            {
                Query = @"
                    query GetProductinfo($serialNumber: String!){
                        fBCMUTQuery{
                            get_ProductConfig_Information_Updated(serialNumber: $serialNumber){
                                productData{
                                    mID
                                }
                            }
                        }
                    }",
                Variables = new { serialNumber = serial }
            };
            try
            {
                var response = await _client.SendQueryAsync<dynamic>(request);
                JObject data = JObject.FromObject(response.Data);

                var configArray = data["fBCMUTQuery"]?["get_ProductConfig_Information_Updated"] as JArray;
                if (configArray != null && configArray.Count > 0)
                {
                    var productDataArray = configArray[0]?["productData"] as JArray;
                    string material = productDataArray != null && productDataArray.Count > 0
                        ? productDataArray[0]?["mID"]?.ToString()
                        : null;
                    return material ?? "No encontrado";
                }
                return "No se encontro informacion de producto";
            }
            catch (Exception ex)
            {
                return $"Error al consultar el material: {ex.Message}";
            }
        }
    }
}
