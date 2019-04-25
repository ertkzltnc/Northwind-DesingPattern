using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entity;

namespace Northwind.Repository
{
    public class RepositoryBase<TT> : IRepository<TT> where TT:class
    {
        /*
         * RepositoryBase class contex ihtiyacımız var. Bu yüzden Northwind.
         * Repository projemize Northwind.Entity projesini referans olarak eklememiz gerekir.
         * 
         * Singleton Pattern : Uygulamamnın tek context yada tek connection üzerinden işlem yapmasının sağlandığı 
         * tasarım desenidir.
         * 
         * Sık bağlantı açılıp kapatılan uygulamalarda bu işlemler sql server'er gereksiz yük bindirir. Bunun yerine 
         * hazırda context nesnesi var mı bakılır , eğer yoksa yeniden oluşturlur varsa  var olan kullanılır.
         * 
         */

        private NorthwindEntities context;
        public  NorthwindEntities Context
        {
            get
            {
                //if (context == null)
                //{
                //    context = new NorthwindEntities();
                //}

                //return context;
                return context ?? new NorthwindEntities();
            }
            set
            {
                context = value;
            }
        }
        public bool Adding(TT entity)
        {
            Context.Set<TT>().Add(entity);
            // Set<TT>(): >Context'in TT tipini algılamasını sağlar
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
                
            }
          
        }

        public bool Deleting(TT entity)
        {
            Context.Set<TT>().Remove(entity);
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<TT> Listing()
        {
            // Product entity gelirse productlar listelenecek , categoprr entity gelirse categoryler listelenecek.
            return Context.Set<TT>().ToList();
           
        }

        public bool Updating(TT entity)
        {

            //Context.Set<TT>().Attach(entity);
            //Context.Entry(entity).State = EntityState.Modified;
           

            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
