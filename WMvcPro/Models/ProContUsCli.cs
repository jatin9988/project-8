using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WMvcPro.Models
{
    public class ProContUsCli
    {
        private string Base_URL = "http://localhost:24275/api/";
        public IEnumerable<ProContUs> ProfindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("ContUsPro").Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<ProContUs>>().Result;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool ProCre(ProContUs procont)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("ContUsPro", procont).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

    }
}