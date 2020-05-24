using Core.DbContexts;
using Core.Interfaces.DAOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.DAOs
{
    public class DataDAO : IDataDAO
    {
        public void Post(Data data)
        {
            using (var context = new ThermometerContext())
            {
                context.Datas.Add(data);
                context.SaveChanges();
            }
        }

        public Data Get(int dataId)
        {
            using (var context = new ThermometerContext())
            {
                return context.Datas.Where(d => d.DataId == dataId)
                                    .FirstOrDefault();
            }
        }

        public Data Get(DateTime read)
        {
            using (var context = new ThermometerContext())
            {
                return context.Datas.Where(d => d.Read == read)
                                    .FirstOrDefault();
            }
        }

        public IList<Data> GetMany()
        {
            using (var context = new ThermometerContext())
            {
              return context.Datas.ToList();
            }
        }

        public IList<Data> GetMany(int count)
        {
            using (var context = new ThermometerContext())
            {
                return context.Datas.OrderByDescending(d => d.Read)
                                    .Distinct()
                                    .ToList();
            }
        }
    }
}
