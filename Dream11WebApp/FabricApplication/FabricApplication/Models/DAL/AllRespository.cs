using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.DAL
{
    public class AllRespository<T> : IAllRespository<T> where T : class
    {
        //private ServiceFabricEntities _context;
        private ServiceFabricEntities7 _context;
        private IDbSet<T> dbEntity;

        public AllRespository()
        {
            _context = new ServiceFabricEntities7();
            dbEntity = _context.Set<T>();
        }
        public IEnumerable<T> GetModel()
        {
            return (dbEntity.ToList());
        }
        public void InsertModel(T model)
        {
            dbEntity.Add(model);
        }

        public void UpdateModel(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }

        public void DeleteModel(T model)
        {
            _context.Entry(model).State = EntityState.Deleted;
        }

        public T GetById(int id)
        {
            return (dbEntity.Find(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}