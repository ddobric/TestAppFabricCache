using Microsoft.ApplicationServer.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAppFabricCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                string cachename = "default";

                string key = "KEY";

                var val = DateTime.Now.ToString();

                if (args != null)
                {
                    if (args.Length == 1)
                        cachename = args[0];

                    if (args.Length == 2)
                        key = args[1];

                    if (args.Length == 3)
                        val = args[2];
                }

                Console.WriteLine("Initializing...");

                DataCacheFactory dcf = new DataCacheFactory();

                Console.WriteLine("Factory created.");

                Console.WriteLine("Connecting to cache '{0}'.", cachename);

                DataCache mycache = dcf.GetCache(cachename);

                Console.WriteLine("Connected successfully to cache.");

                mycache.Add(key, val);

                Console.WriteLine("Added value to cache {0}-{1}", key, val);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                trace(ex);
            }
        }

        private static void trace(Exception ex)
        {
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
                trace(ex.InnerException);
        }
    }
}
