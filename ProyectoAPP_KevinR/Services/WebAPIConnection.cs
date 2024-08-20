using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAPP_KevinR.Services
{
    public static class WebAPIConnection
    {

        public static string BaseURL = "http://192.168.0.195:45455/api/";

        //aca tambien es importante incluir la info de seguridad como el API key
        //ya que debe ser incluido en cada llamada a los end point del API


        public static string ApiKeyName = "Apikey";
        public static string ApiKeyValue = "KevinProyP6";

        

    }
}
