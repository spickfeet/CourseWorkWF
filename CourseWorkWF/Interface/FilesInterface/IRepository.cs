using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    public interface IRepository<K,T> where T : class where K : notnull
    {
        public bool Create(T entity);
        public IReadOnlyDictionary<K, T> ReadAll();
        public bool Update(T entity);
        public bool Delete(T entity);
        public Dictionary<K, T> Load();
    }  
}
