using Northwind.DTO;
using Northwind.Entity;
using Northwind.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Northwind.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : ServiceBase<ProductRepository,Products,ProductDTO>
    {
       //ProductService isimli bir service olusturunca , arka planda IProductService isimli bir interface olustur.
       //ProductService servisimiz IProductService isimli ınterfac'den türetirsek yani hiyerarşiyi bu şekilde bırkakırsak ,IService ve
        //ServiceBase  içindeki method'lar kullanılmayacak . Oysaki biz IService ve ServiceBase içindeki method'ların tüm Service'le
        //(Product,Category vb.) tekrar tekrar yazılmaması için oluşturmuştuk.
    }
}
