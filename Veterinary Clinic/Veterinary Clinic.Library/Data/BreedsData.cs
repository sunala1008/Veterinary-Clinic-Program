using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Library.Data
{
    public class BreedsData : EntityData<Breeds>
    {
        public List<Breeds> GetBreeds(int selectedValue)
        {
            using (VETEntities entities = new VETEntities())
            {
                var query = from x in entities.Breeds
                            where x.SpeciesID == selectedValue
                            select x;

                return query.ToList();
            }
        }
    }
}
