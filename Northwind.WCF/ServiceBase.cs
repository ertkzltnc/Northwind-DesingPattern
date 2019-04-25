using Northwind.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.WCF
{
    public class ServiceBase<Rep, Entity, DTO> : IService<DTO> where DTO : class where Entity:class 
        where Rep:RepositoryBase<Entity>
    {
        /* Rep:RepositoryBase<Entity> ServiceBase'in Rep hareket tipi RepositoryBase tipinde olduğu beliritildiği için 
         * ServiceBase class'ını kullandığımız yerlerde Rep hareket tipi için  ProductRepository?CategoryRepository? vb..
         * yazılabilir. Çünkü bu sınıflar RepositoryBase class'ından türemiştir.
    {
         * 
         * ServiceBase class'ı RepositoryBase class'ına talep gönderen ve RepositoryBase class'ından responsları alan bir class'dır.
         * ServiceBase claS'ının  hangi RepositoryBase class'ı(ProductRepository?CategoryRepository? vb..)
         * ile iletişimde olduğunu bilmek gerekir.Ayrica ServiceBase class'ı  clientE DTO nesnesi yollamalı ve Client'tan gelen DTO 
         * nesnesini RepositoryBase sınıfına gönderirken Entity'e dönüştürmesi gerekir.
         * 
         * ServiceBase'in hem repository tipi hem Entity tipi hemde DTO tipi argümanlarına ihtiyacı vardır.
         * 
         
         */
        public bool Adding(DTO dto)
        {
            throw new NotImplementedException();
        }

        public bool Deleting(DTO dto)
        {
            throw new NotImplementedException();
        }

        public List<DTO> Listind()
        {
            /*
             * 
             */

            throw new NotImplementedException();
        }

        public bool Updating(DTO dto)
        {
            throw new NotImplementedException();
        }
    }
}