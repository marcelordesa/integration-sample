using integration_sample_domains.Contracts.Infra;
using integration_sample_domains.Entities.CompanyA;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace integration_sample_infra
{
    public class CompanyAServiceContext : ICompanyAServiceContext
    {
        public static string urlApi { get; set; }
        public static string userApi { get; set; }
        public static string passwordApi { get; set; }
        public static string companyApi { get; set; }
        public static string lineApi { get; set; }

        public async Task<bool> PostDocumentAccount(DocumentAccount documentAccount)
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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokens.AccessToken);
                var _documentAccount = JsonSerializer.Serialize(documentAccount);
                var content = new StringContent(_documentAccount, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("Contabilidade/TiposDocumento/Actualiza/avisos", content);
                if (response.IsSuccessStatusCode)
                {
                    result = true;
                }
            }

            return result;
        }

        public async Task<DocumentAccount> GetDocumentAccount(string TipoDoc, string Serie, string Numdoc, string Filial, string Numvias, string NomeReport, string SegundaVia, string NomePDF, string EntidadeFacturacao)
        {
            var tokens = await PostGenerateToken();
            DocumentAccount documentAccount = null;

            if (tokens == null)
                return documentAccount;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokens.AccessToken);
                HttpResponseMessage response = await client.GetAsync($"ClassExtended/PrintSalesDocToPDF/{TipoDoc}/{Serie}/{Numdoc}/{Filial}/{Numvias}/{NomeReport}/{SegundaVia}/{NomePDF}/{EntidadeFacturacao}");
                if (response.IsSuccessStatusCode)
                {
                    var reponseString = await response.Content.ReadAsStringAsync();
                    documentAccount = JsonSerializer.Deserialize<DocumentAccount>(reponseString);
                }
            }

            return documentAccount;
        }

        private async Task<TokenResponse> PostGenerateToken()
        {
            TokenRequest tokenRequest = new TokenRequest { Company = companyApi, GrantType = "password", Instance = "Default", Line = lineApi, UserName = userApi, Password = passwordApi };

            TokenResponse tokenResponse = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                var _tokenRequest = JsonSerializer.Serialize(tokenRequest);
                var content = new StringContent(_tokenRequest, Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("token", content);
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