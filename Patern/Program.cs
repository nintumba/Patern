using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABF
{
    class Program
    {

        public static void Main()
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();
            System.Threading.Thread.Sleep(10000000);
        }
    }
}
