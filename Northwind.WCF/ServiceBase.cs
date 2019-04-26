using Northwind.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.Extensions;
using Northwind.DTO;
using Northwind.Entity;

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
        private Rep repository;
        public Rep Repository
        {
            get
            {
                //Generic tip için instance oluşturmak istediğimizde new Rep gibi bir işlem yapamıyoruz.
                // generic tip için instance oluşturmada oluşturulacak class'ın adı Activator ve metodun adı 
                // CreateInstance isimli Generic Method'dur.

                //CreateInstance<Rep>(); Rep dışarıdan alınan tiptir ve instance bu tip için üretilecektir.
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }
            set
            {
                repository = value;
            }
        }

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
            //return Repository.Listing();
            /*ServiceBase'inden RepositoryBase'ine taleb gönderilecektir.
             * 
             * Service katmanımız Repository'den entity alır. Öncelikle alınan entity'leri DTO nesnensine dönüştürülmesi gerekir.
             * Bizim DTO-to-Entity ve Entity-to-DTO çevrimine ihitiyacımız vardır.
             */
            //throw new NotImplementedException();



            /* d.Changer<Products>(): d.'nın anlamı, Changer method'un hangi kaynak(source) üstünden ulaştığımızı gösterir.
             * Yani Changer'A pRODUCTdto üzerinden ulaşıyorsunuz. Başka bir deyişle  ProductDto nesnesini dönüştürüyorsunuz.
             * 
             * <Products>(): Changer method'un dışarıdan istediği argüman tipi gösterir. Changer hangi argüman tip gösterirse 
             * dışarıdan onu alır..
             *  Products prod: Changer method'un return tipini gösterir.
             */
            ProductDTO d = new ProductDTO();
            Products prod = d.Changer<Products>();

            Products p = new Products();
            ProductDTO pdto = p.Changer<ProductDTO>();
         
               
            





        }

        public bool Updating(DTO dto)
        {
            throw new NotImplementedException();
        }
    }
}