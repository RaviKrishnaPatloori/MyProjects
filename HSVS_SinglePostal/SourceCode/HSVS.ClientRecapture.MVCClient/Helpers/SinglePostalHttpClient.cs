using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Web;
using System.Globalization;
using HSVS.SinglePostal.Utilities;

namespace HSVS.SinglePostal.WebApp.Helpers
{
    public static class SinglePostalHttpClient
    {        

        public static HttpClient GetClient()
        {      
            HttpClient client = new HttpClient();           
            client.BaseAddress = new Uri(Constants.SinglePostalAPI);         
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }         
    }
}