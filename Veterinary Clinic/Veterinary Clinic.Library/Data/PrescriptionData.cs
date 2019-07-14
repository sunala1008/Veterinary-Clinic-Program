using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Library.Data
{
    public class PrescriptionData : EntityData<Prescription>
    {
        public List<Prescription> GetRecord(int patientID)
        {
            using (VETEntities entities = new VETEntities())
            {
                var query = from x in entities.Prescription
                            where x.PatientID == patientID
                            select x;

                List<Prescription> prescriptions = query.ToList();

                return prescriptions;
            }
        }
    }
}
