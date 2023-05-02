using ProjectEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBll.Repositories.IntRep
{
    public interface IRepository<B> where B : BaseEntity
    {
        //List Commands
        List<B> GetAll();
        List<B> GetPassives();
        List<B> GetActives();
        List<B> GetModifieds();

        //Modify Commands
        void Add(B item);
        void AddRange(List<B> items);
        void Update(B item);
        void UpdateRange(List<B> items);
        void Delete(B item);
        void DeleteRange(List<B> items);
        void Destroy(B item);
        void DestroyRange(List<B> items);

        //Linq Commands
        List<B> Where(Expression<Func<B, bool>> exp);
        bool Any (Expression<Func<B, bool>> exp);
        B FirstOrDefault(Expression<Func<B, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<B, X>> exp);
        object Select(Expression<Func<B, object>> exp);

        //Find
        B Find(int id);

        //LastDatas
        List<B> GetLastDatas(int number);

        //FirstDatas
        List<B> GetFirstDatas(int number);
    }
}
