using System.Collections.Generic;
using System.Threading.Tasks;
using CernerMpageDemo.Models;           // Asegúrate que PatientModel.cs tenga namespace CernerMpageDemo.Models
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace CernerMpageDemo.Services
{
    public interface IFhirService
    {
        Task<List<PatientModel>> GetPatientsAsync();
    }

    public class FhirService : IFhirService
    {
        public async Task<List<PatientModel>> GetPatientsAsync()
        {
            var patients = new List<PatientModel>();

            // Configuramos el FhirClient con JSON
            var settings = new FhirClientSettings
            {
                PreferredFormat = ResourceFormat.Json
            };

            // Creamos el cliente apuntando a hapi.fhir.org/baseR4
            var client = new FhirClient("http://hapi.fhir.org/baseR4", settings);

            // Construimos los parámetros de búsqueda
            var sp = new SearchParams();
            sp.Count = 5;    // _count=5

            // Obtenemos un Bundle de Patient
            var bundle = await client.SearchAsync<Patient>(sp);

            int count = 0;

            // Recorremos el Bundle
            foreach (var entry in bundle.Entry)
            {
                if (entry.Resource is Patient pat)
                {
                    var name = pat.Name?.Count > 0 ? pat.Name[0] : null;
                    var fullName = (name == null)
                        ? "Sin nombre"
                        : $"{string.Join(' ', name.Given ?? new string[0])} {name.Family}";

                    patients.Add(new PatientModel
                    {
                        Id = pat.Id,
                        FullName = fullName
                    });

                    // Si solo quieres 2 pacientes, pon:
                    count++;
                    if (count == 2) break;
                }
            }

            return patients;
        }
    }
}
