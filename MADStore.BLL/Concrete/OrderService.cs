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
    public class OrderService : IOrderService
    {
        IOrderDAL _orderDAL;

        public OrderService(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }

        public void Insert(Order entity)
        {
            _orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            _orderDAL.Update(entity);
        }

        public void Delete(Order entity)
        {
            _orderDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Order ord = _orderDAL.Get(a => a.ID == entityID);
            _orderDAL.Delete(ord);
        }

        public Order Get(int entityID)
        {
            return _orderDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderDAL.GetAll();
        }
    }
}
