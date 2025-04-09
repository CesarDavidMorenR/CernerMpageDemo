using System;
using System.Collections.Generic;

namespace CernerMpageDemo.Services
{
    public interface ICclService
    {
        List<LabResult> GetLabResults();
    }

    public class CclService : ICclService
    {
        public List<LabResult> GetLabResults()
        {
            // Supongamos que hemos hecho la llamada a CCL y nos devuelve estos resultados
            // típicos de una base de datos Cerner. Aquí solo simulamos.
            return new List<LabResult>
            {
                new LabResult { ResultValue = "135 mg/dL", DateTime = DateTime.Now.AddDays(-1) },
                new LabResult { ResultValue = "140 mg/dL", DateTime = DateTime.Now.AddDays(-2) },
            };
        }
    }
}