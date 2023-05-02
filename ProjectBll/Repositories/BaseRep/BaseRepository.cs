using ProjectBll.DesignPatterns.SingletonPattern;
using ProjectBll.Repositories.IntRep;
using ProjectDal.Context;
using ProjectEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBll.Repositories.BaseRep
{
    public class BaseRepository<B> : IRepository<B> where B : BaseEntity
    {
        protected MyContext _context;
        public BaseRepository()
        {
            _context = DBTool.DbInstance;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Add(B item)
        {
            _context.Set<B>().Add(item);
            Save();
        }

        public void AddRange(List<B> items)
        {
            _context.Set<B>().AddRange(items);
            Save();
        }

        public bool Any(Expression<Func<B, bool>> exp)
        {
            return _context.Set<B>().Any(exp);
        }

        public void Delete(B item)
        {
            item.DeletedDate = DateTime.Now;
            item.DataStatus = ProjectEntities.Enums.DataStatus.Deleted;
            Save();
        }

        public void DeleteRange(List<B> items)
        {
            foreach (B item in items)
            {
                Delete(item);
            }
        }

        public void Destroy(B item)
        {
            _context.Set<B>().Remove(item);
            Save();
        }

        public void DestroyRange(List<B> items)
        {
            _context.Set<B>().RemoveRange(items);
        }

        public B Find(int id)
        {
            return _context.Set<B>().Find(id);
        }

        public B FirstOrDefault(Expression<Func<B, bool>> exp)
        {
            return _context.Set<B>().FirstOrDefault(exp);
        }

        public List<B> GetActives()
        {
            return Where(x => x.DataStatus != ProjectEntities.Enums.DataStatus.Deleted);
        }

        public List<B> GetAll()
        {
            return _context.Set<B>().ToList();
        }

        public List<B> GetFirstDatas(int number)
        {
            return _context.Set<B>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<B> GetLastDatas(int number)
        {
            return _context.Set<B>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();
        }

        public List<B> GetModifieds()
        {
            return Where(x => x.DataStatus == ProjectEntities.Enums.DataStatus.Updated);
        }

        public List<B> GetPassives()
        {
            return Where(x => x.DataStatus == ProjectEntities.Enums.DataStatus.Deleted);
        }

        public IQueryable<X> Select<X>(Expression<Func<B, X>> exp)
        {
            return _context.Set<B>().Select(exp);
        }

        public object Select(Expression<Func<B, object>> exp)
        {
            return _context.Set<B>().Select(exp).ToList();
        }

        public void Update(B item)
        {
            item.UpdateDate = DateTime.Now;
            item.DataStatus = ProjectEntities.Enums.DataStatus.Updated;
            B toBeUpdated = Find(item.ID);
            _context.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateRange(List<B> items)
        {
            foreach (B item in items)
            {
                Update(item);
            }
        }

        public List<B> Where(Expression<Func<B, bool>> exp)
        {
            return _context.Set<B>().Where(exp).ToList();
        }
    }
}
