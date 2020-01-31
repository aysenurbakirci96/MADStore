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
    public class ColorService : IColorService
    {
        IColorDAL _colorDAL;

        public ColorService(IColorDAL colorDAL)
        {
            _colorDAL = colorDAL;
        }

        public void Insert(Color entity)
        {
            _colorDAL.Add(entity);
        }

        public void Update(Color entity)
        {
            _colorDAL.Update(entity);
        }

        public void Delete(Color entity)
        {
            _colorDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Color clr = _colorDAL.Get(a => a.ID == entityID);
            _colorDAL.Delete(clr);
        }

        public Color Get(int entityID)
        {
            return _colorDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Color> GetAll()
        {
            return _colorDAL.GetAll();
        }
    }
}
