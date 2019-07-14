using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Library.Data
{
    public class DB
    {
        static DB()
        {
            Patient = new PatientData();
            Companion = new CompanionData();
            Employee = new EmployeeData();
            Breeds = new BreedsData();
            Species = new SpeciesData();
            Operation = new OperationData();
            Disease = new DiseaseData();
            Drug = new DrugData();
            Prescription = new PrescriptionData();
        }

        public static PatientData Patient { get; }
        public static CompanionData Companion { get; }
        public static EmployeeData Employee { get; }
        public static BreedsData Breeds { get; }
        public static SpeciesData Species { get; }
        public static OperationData Operation{ get; }
        public static DiseaseData Disease{ get; }
        public static DrugData Drug{ get; }
        public static PrescriptionData Prescription{ get; }
    }
}
