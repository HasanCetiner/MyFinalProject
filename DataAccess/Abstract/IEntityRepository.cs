using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T yerine her şeyi yazmamızı engelleyen(mesela int yazılmassın gibi) şeye "generic constraint" denir
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı. Interface'ler newlenemeyeceği için aşağıda T'nin yerine interface koymamak amacıyla new() yazdık
    public interface IEntityRepository<T> where T:class,IEntity,new() /*IEntity tabanlı bir nesne(class) olsun istiyorum ama  IEntity'i hariç tutmak için new() yazdık*/
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        // Yukarıdaki Expression fonksiyonu ile sağdaki gibi fitrelemeye gerek kalmaz List<T> GetAllByCategory(int CategoryID);
    }
}
