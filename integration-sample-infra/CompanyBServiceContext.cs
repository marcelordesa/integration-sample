using integration_sample_domains.Entities.CompanyB;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;
using integration_sample_domains.Contracts.Infra;

namespace integration_sample_infra
{
    public class CompanyBServiceContext : ICompanyBServiceContext
    {
        public static string urlApi { get; set; }
        public static string userApi { get; set; }
        public static string passwordApi { get; set; }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            var tokens = await PostGenerateToken();
            List<Invoice> listInvoice = new List<Invoice>();

            if (tokens == null)
                return listInvoice;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokens.access_token);
                HttpResponseMessage response = await client.GetAsync("2.0/admin/finance/invoices");
                if (response.IsSuccessStatusCode)
                {
                    var reponseString = await response.Content.ReadAsStringAsync();
                    listInvoice = JsonSerializer.Deserialize<List<Invoice>>(reponseString);
                }
            }

            return listInvoice;
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            var tokens = await PostGenerateToken();
            Invoice invoice = null;

            if (tokens == null)
                return invoice;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("CompanyB-EA", $"(access_token={tokens.access_token})");
                HttpResponseMessage response = await client.GetAsync($"2.0/admin/finance/invoices/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var reponseString = await response.Content.ReadAsStringAsync();
                    invoice = JsonSerializer.Deserialize<Invoice>(reponseString);
                }
            }

            return invoice;
        }

        public async Task<bool> PostInvoices(Invoice invoice)
        {
            var tokens = await PostGenerateToken();
            bool result = false;

            if (tokens == null)
                return result;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("CompanyB-EA", $"(access_token={tokens.access_token})");
                var _invoice = JsonSerializer.Serialize(invoice);
                var content = new StringContent(_invoice, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("2.0/admin/finance/invoices", content);
                if (response.IsSuccessStatusCode)
                {
                    result = true;
                }
            }

            return result;
        }

        private async Task<TokenResponse> PostGenerateToken()
        {
            TokenRequest tokenRequest = new TokenRequest { AuthType = "customer", Login = userApi, Password = passwordApi };

            TokenResponse tokenResponse = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var _tokenRequest = JsonSerializer.Serialize(tokenRequest);
                var content = new StringContent(_tokenRequest, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("2.0/admin/auth/tokens", content);
                if (response.IsSuccessStatusCode)
                {
                    var reponseString = await response.Content.ReadAsStringAsync();
                    tokenResponse = JsonSerializer.Deserialize<TokenResponse>(reponseString);
                }
            }

            return tokenResponse;
        }
    }
}