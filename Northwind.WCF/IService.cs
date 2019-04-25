using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Northwind.WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO:class
    {
        //Service Katmanı client'den talebi alıp repository katmanına iletir.
        // IService interface'i ve içerisiinde tanımlı metodlar client ile iletişime gececeği için sözleşme içine dahil edilmesi gerekir.

 
            /* 
             * Bu katmnınj olmasının sebebi,Client'ların direkt olarak Entity ve Faceda'lara ulaşması içindir.
             * 
             * Service katmanına Client tarafıondan gelen nesneler DTO nesneleridir(Entity nesneleri gelmez)
             * 
             * DTO: Katmanı Entity'lerin aynısı olacaktır sadece DTO içerisinde serilize edilebilir nesneler barındırır.
             * 
             * Client ile service arasında gidip/gelen nesnelerin serilize edilebilir olması gerekir.
             
             
             */
        [OperationContract]
        List<DTO> Listind();
        [OperationContract]
        bool Adding(DTO dto);
        [OperationContract]
        bool Updating(DTO dto);
        [OperationContract]
        bool Deleting(DTO dto);
    }
}