using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Extensions
{
    //extension metodlar ve bu metodların bulunduğu class lar static olmalıdır. 
     
    public static class Extension
    {
        /*C#' ta bulunan Object class'ının içine yeni bir metod ekleyeceğiz.
         * 
         * (this Object source): Object tipinin içerisinde Changer metodu eklenecektir.Bu yazım tarzı ile hali hazırda bulunan 
         * bir class'ın içerine dışarıdan bir method eklemiş olacağız.Bundan sonra projenin içerisine herhangi bir sınıf eklendiğinde 
         * bu method o sınıfın içinde otomatik olarak varmış gibi olacak(inheritance dan doalyı).Kısacası bu gösterim 
         * Extension method gösterimidir.
         * 
         * T Changer<T>(this Object source): Source elamanı hangi instance üzerinden  . yazarak method'a ulaşıyorsa  o instance'yi 
         * temsil eder.Biz Changer method'u ile source elamının T tipine dönüştüreceğiz ve geriye T tipinde eleman döndüreceğiz.
         * 
         * Product nensensinin içindeki property'leri ProductDTO içerisine koyacağız yada ProductDTO içerisindeki property'leri Product
         * nesnesinin içerisine koyacağız.
         * 
         * 
         */
         /// <summary>
         /// Product nensensinin içindeki property'leri ProductDTO içerisine koyacağız yada ProductDTO içerisindeki property'leri Product
         /// nesnesinin içerisine koyacağız.
         /// </summary>
         /// <typeparam name="T"></typeparam>
         /// <param name="source"></param>
         /// <returns></returns>
        public static T Changer<T>(this Object source)
        {
            // T tipinde instance oluştu ve  oluşan instance'yi  yine T tipinde bir değişkene ata;
            T target = Activator.CreateInstance<T>();
            Type targetType = target.GetType();
            Type sourceType= source.GetType();
            PropertyInfo[] sourceProperties= sourceType.GetProperties();
            PropertyInfo[] targetProperties = targetType.GetProperties();
            foreach (PropertyInfo pInf in sourceProperties)
            {
                object value=pInf.GetValue(source);
                PropertyInfo targetpInf=targetProperties.FirstOrDefault(x => x.Name == pInf.Name);
                if (targetpInf!=null)
                {
                    targetpInf.SetValue(target, value);
                }
                
            }
            return target;

        }
    }
}
