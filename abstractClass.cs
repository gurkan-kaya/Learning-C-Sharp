using System;

namespace AbstractClass
{
    //Abstract classtaki abstract metot veya propertyler , bu sınıftan kalıtım alan her sınıfta implemente edilmelidir.
    //Abstract classtaki abstract olmayan metot veya propertyler , bu sınıftan kalıtım alan sınıflaraa implemente edilmek zorunda değildir.
    //Metot veya propertyler implemente edilirken "override" anahtar sözcüğü kullanılmalıdır.
    //Abstract sınıflarda abstract olmayan elemanlar da olabilir. 
    //Public veya private olmalıdır.
    //Abstract sınıflardan nesne oluşturulmaz ancak referans noktası alınabilir.
    //Abstract metot ya da propertylerin sadece signatureleri abstract classta yazılır,gövdeleri yazılmaz.
    abstract class MyClass
    {
        public abstract void X(); //Sadece imza tanımladık
        public void Y() { } //Abstract olmak zorunda değil.
    }

    class MyClass2 : MyClass
    {
        public override void X()
        {
         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // MyClass mc = new MyClass();  (Hatalı bir kullanımdır)

            MyClass mc = new MyClass2(); //Abstract referans noktası üzerinden derived classın nesnesine erişim sağladık.(Polimorfizm)
        }
    }
}


