using Core.Models;
using System.Collections.Generic;

namespace Core.Interfaces.DAOs
{
    public interface IDataDAO
    {
        public void Post(Data data);
        public Data Get(int dataId);
        public IList<Data> GetMany();
        public IList<Data> GetMany(int count);
    }
}
