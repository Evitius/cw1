using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int? tmp1 = null;
            //double tmp2 = 2.0;
            //string tmp3 = "string";
            //bool tmp4 = true;
            var tmp5 = "cos takiego";
            var tmp6 = "i psa";
            int w = 3;
            int q = 2;
            string path = $@"C:\Users\s18803\";

            Console.WriteLine($"{tmp5} {tmp6} {w+q} ");

            var newPerson = new Person { FirstName = "Daniel" };

            var url =  args.Length > 0 ? args[0] : "http://www.pja.edu.pl";
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);

            // 2xx
            if (response.IsSuccessStatusCode)
            {
                var htmlContent =  await response.Content.ReadAsStringAsync();


                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                var matches = regex.Matches(htmlContent);

                foreach(var match in matches)
                {
                    Console.WriteLine(match.ToString());

                }




            }


        }
    }
}
