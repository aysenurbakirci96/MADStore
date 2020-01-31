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
    public class CommentService : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentService(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void Insert(Comment entity)
        {
            _commentDAL.Add(entity);
        }

        public void Update(Comment entity)
        {
            _commentDAL.Update(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Comment cmt = _commentDAL.Get(a => a.ID == entityID);
            _commentDAL.Delete(cmt);
        }

        public Comment Get(int entityID)
        {
            return _commentDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Comment> GetAll()
        {
            return _commentDAL.GetAll();
        }
    }
}
