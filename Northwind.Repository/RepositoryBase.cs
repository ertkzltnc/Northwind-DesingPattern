using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool Adding(TT entity)
        {
            throw new NotImplementedException();
        }

        public bool Deleting(TT entity)
        {
            throw new NotImplementedException();
        }

        public List<TT> Listing()
        {
            throw new NotImplementedException();
        }

        public bool Updating(TT entity)
        {
            throw new NotImplementedException();
        }
    }
}
