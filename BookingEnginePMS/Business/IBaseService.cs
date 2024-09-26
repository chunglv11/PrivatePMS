using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingEnginePMS.Business
{
    public interface IBaseService<TEntity, TKey> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(TKey key);
        TEntity Insert(TEntity entity);
        void Update(TKey key, TEntity entity);
        void DeleteById(TKey key);
    }

    public interface IBaseServiceMultiHotel<TEntity, TKey> where TEntity : class
    {
        List<TEntity> GetAll(int hotelId);
        TEntity GetById(int hotelId, TKey key);
        TEntity Insert(int hotelId, TEntity entity);
        void Update(int hotelId, TKey key, TEntity entity);
        void DeleteById(int hotelId, TKey key);
    }
}
