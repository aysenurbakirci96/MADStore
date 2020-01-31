using MADStore.BLL.Abstract;
using MADStore.DAL.Abstract;
using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.BLL.Concrete
{

    public class ShipperService : IShipperService
    {
        IShipperDAL _shipperDAL;

        public ShipperService(IShipperDAL shipperDAL)
        {
            _shipperDAL = shipperDAL;
        }

        public void Insert(Shipper entity)
        {
            _shipperDAL.Add(entity);
        }

        public void Update(Shipper entity)
        {
            _shipperDAL.Update(entity);
        }

        public void Delete(Shipper entity)
        {
            _shipperDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Shipper shp = _shipperDAL.Get(a => a.ID == entityID);
            _shipperDAL.Delete(shp);
        }

        public Shipper Get(int entityID)
        {
            return _shipperDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Shipper> GetAll()
        {
            return _shipperDAL.GetAll();
        }
    }
}
