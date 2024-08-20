using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAPP_KevinR.Models
{
    public class Empleado
    {
        [JsonIgnore]
        public RestRequest Request { get; set; }
        public int EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public string Last_name { get; set; } = null!;

        public string Post { get; set; } = null!;

        public int Phone { get; set; }

        public string E_mail { get; set; } = null!;

        public string Password { get; set; } = null!;

        public async Task<bool> AddEmpleadoAsync()
        {
            try
            {
                string RouteSufix = string.Format("Empleados/AddEmpleadoFromApp");

                string URL = Services.WebAPIConnection.BaseURL + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Post);

                Request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);


                string SerializedModel = JsonConvert.SerializeObject(this);

                Request.AddBody(SerializedModel);

                RestResponse response = await client.ExecuteAsync(Request);

                
                HttpStatusCode statusCode = response.StatusCode;

                if (response != null && statusCode == HttpStatusCode.Created)
                {
 
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }
}
