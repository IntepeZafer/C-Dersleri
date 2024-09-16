using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(3, 5);
            //Console.WriteLine(dortIslem.Topla());
            //Console.WriteLine(dortIslem.Carp());

            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 7);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(typeof(DortIslem), 6, 7);
            instance.GetType().GetMethod("Topla").Invoke(instance, null);
            //Console.WriteLine(dortIslem.Topla());
            var methodlar = type.GetMethods();
            foreach (var m in methodlar) { 
                Console.WriteLine("Method Adı : {0}", m.Name);
            }
            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        int _Sayi1;
        int _Sayi2;
        public DortIslem(int Sayi1 , int Sayi2)
        {
            _Sayi1 = Sayi1;
            _Sayi2 = Sayi2;
        }
        public int Topla()
        {
            return _Sayi1 + _Sayi2;
        }
        public int Carp()
        {
            return _Sayi1 * _Sayi2;
        }
    }
}
