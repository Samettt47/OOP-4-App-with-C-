using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            new D();

            #region BASE KEYWORD
            //  Eğer base classın ctoru sadece parametre alan ctor ise child
            //  classlarda o ctora bir değer göndermek zorundayız
            //  Bunuda Base keywordu ile sağlarız
            //  Eğer ki base classta boş parametreli bir ctor varsa child classta
            //  base ile ilgili bir bildirimde bulunmak zorunda değiliz . 
            // Çünkü varsayılan olarak kalıtımsal durumda base classta
            // boş parametreli ctor tetiklenir

            new MyClass2();
            #endregion
        }
    }
    class MyClass
    {
        public int MyProperty { get; set; }
        public int a = 3;
        public MyClass(int a)
        {
            
            Console.WriteLine($"{nameof(MyClass)} değeri : " + a );
        }
        public MyClass()
        {

        }
        public MyClass(string a )
        {
            Console.WriteLine($"{nameof(MyClass)} değeri : " + a);
        }
        public MyClass(int a , string b)
        {

        }
    }
    class MyClass2 : MyClass
    {
        public MyClass2()  : base("samet")
        {

        }
        public MyClass2(int a) : base(4)
        {
           
        }
        private void Z()
        {
            base.MyProperty = 20;
            base.a = 10;
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} nesnesi oluşturulmuştur");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} nesnesi oluşturulmuştur");
        }
    }
    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} nesnesi oluşturulmuştur");
        }
    }

}
