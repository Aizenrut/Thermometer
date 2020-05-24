using Core.DAOs;
using Core.Interfaces.Engines;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Engines
{
    public class Engine : IEngine
    {
        public void PostAsync(string json)
        {
            var factory = new TaskFactory().StartNew(
            () =>
            {
                var factory = new Factory();
                var data = factory.BuildData(json);

                if (data != null)
                {
                    var dao = new DataDAO();
                    dao.Post(data);
                }
            });
        }

        public IList<Data> GetData()
        {
            var dao = new DataDAO();
            return dao.GetMany(15);
        }

        public double GetHighestTemperature()
        {
            var dao = new DataDAO();
            var datas = dao.GetMany(15);

            if (datas == null || datas.Count == 0)
            {
                return 0;
            }

            return datas.OrderByDescending(d => d.Temperature)
                        .FirstOrDefault()
                        .Temperature;
        }

        public double GetLowestTemperature()
        {
            var dao = new DataDAO();
            var datas = dao.GetMany(15);

            if (datas == null || datas.Count == 0)
            {
                return 0;
            }

            return datas.OrderBy(d => d.Temperature)
                        .FirstOrDefault()
                        .Temperature;
        }
    }
}
