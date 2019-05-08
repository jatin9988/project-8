using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WMvcPro.Models
{
    public class ProLogInCli
    {

        private string Base_URL = "http://localhost:24275/api/";

        public ProLogIn ProLogCre(ProLogIn prolog)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("ProLogIn", prolog).Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<ProLogIn>().Result;
                return null;

            }
            catch
            {
                return null;
            }
        }

    }
}