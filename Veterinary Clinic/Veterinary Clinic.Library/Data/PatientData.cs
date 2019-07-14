using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Library.Data
{
    public class PatientData : EntityData<Patient>
    {        
        public List<Patient> Search(string phoneNum, string petName, int? speciesId)
        {
            using (VETEntities entities = new VETEntities())
            {                
                entities.Database.Log = x => Debug.WriteLine(x);

                var query = from x in entities.Patient
                            select new
                            {
                                patient = x,
                                CompanionName = x.Companion.Name,
                                EmployeeName = x.Employee.Name,
                                BreedsName = x.Breeds.Name,
                                PhoneNumber = x.Companion.Phone,
                                SpeciesId = x.Breeds.SpeciesID
                            };
                
                if (string.IsNullOrEmpty(phoneNum) == false)
                    query = query.Where(x => x.patient.Companion.Phone.Contains(phoneNum));

                if (string.IsNullOrEmpty(petName) == false)
                    query = query.Where(x => x.patient.Name.Contains(petName));

                if (speciesId != null)
                    query = query.Where(x => x.SpeciesId == speciesId);

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.patient.CompanionName = item.CompanionName;
                    item.patient.EmployeeName = item.EmployeeName;
                    item.patient.BreedsName = item.BreedsName;
                    item.patient.PhoneNumber = item.PhoneNumber;
                    item.patient.SpeciesID = item.SpeciesId;
                }

                return list.ConvertAll(x => x.patient);
            }
        }

        public Patient SearchFromTreatementControl(string petName)
        {
            using (VETEntities entities = new VETEntities())
            {
                var query = from x in entities.Patient
                            select x;

                if (string.IsNullOrEmpty(petName) == false)
                    query = query.Where(x => x.Name.Contains(petName));

                Patient patient = new Patient();

                foreach (var item in query)
                {
                    patient = item;
                }

                return patient;
            }
        }
    }
}
