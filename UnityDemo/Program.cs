using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //UnityHelper.TestTransientLifetimeManager();

                //Console.WriteLine("####");
                //UnityHelper.TestContainerControlledLifetimeManager();

                //Console.WriteLine("####");
                //UnityHelper.TestHierarchicalLifetimeManager();

                //Console.WriteLine("####");
                //UnityHelper.TestExternallyControlledLifetimeManager();

                //Console.WriteLine("####");
                //UnityHelper.TestPerThreadLifetimeManager();

                Console.WriteLine("####");
                UnityHelper.TestPerResolveLifetimeManager();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
