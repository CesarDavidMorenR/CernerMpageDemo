using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace CernerMpageDemo.Services
{
    public interface IFhirService
    {
        Task<List<PatientModel>> GetPatientsAsync();
    }

    public class FhirService : IFhirService
    {
        private readonly HttpClient _httpClient;

        public FhirService()
        {

            _httpClient = new HttpClient();
        }

        public async Task<List<PatientModel>> GetPatientsAsync()
        {

            string url = "http://hapi.fhir.org/baseR4/Patient?_count=5";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();


            string jsonString = await response.Content.ReadAsStringAsync();

            var patients = new List<PatientModel>
            {
                new PatientModel { Id = "1", FullName = "John Doe" },
                new PatientModel { Id = "2", FullName = "Jane Smith" }
            };

            return patients;
        }
    }
}