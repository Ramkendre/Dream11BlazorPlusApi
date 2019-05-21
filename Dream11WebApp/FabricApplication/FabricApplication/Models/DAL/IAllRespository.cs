using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.DAL
{
  public   interface IAllRespository<T> where T : class
    {
        IEnumerable<T> GetModel();

        void InsertModel(T model);

        void UpdateModel(T model);

        T GetById(int id);

        void DeleteModel(T model);

        void Save();

        
    }
}
