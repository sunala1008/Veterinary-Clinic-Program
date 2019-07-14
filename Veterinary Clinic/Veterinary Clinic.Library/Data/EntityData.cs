using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary_Clinic.Library.Data
{
    public class EntityData<T> where T : class
    {
        public List<T> GetAll()
        {
            using (VETEntities entities = new VETEntities())
            {
                return entities.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (VETEntities entities = new VETEntities())
            {
                return entities.Set<T>().Count();
            }
        }

        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (VETEntities entities = new VETEntities())
            {
                return entities.Set<T>().Select(selector).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (VETEntities entities = new VETEntities())
            {
                entities.Set<T>().Add(entity);
                //entities.Entry(entity).State = EntityState.Added;

                try
                {
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show("ValidatoinExceptionTest");
                    throw;
                }
            }
        }

        public void Update(T entity)
        {
            using (VETEntities entities = new VETEntities())
            {
                entities.Entry(entity).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (VETEntities entities = new VETEntities())
            {
                entities.Entry(entity).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }
    }
}
