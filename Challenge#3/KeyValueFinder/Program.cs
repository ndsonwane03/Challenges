using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KeyValueFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = @"{""a"":{""b"":{""c"":""d""}}}";
            var val = getString(json, "a/b/c");
            Console.WriteLine($"a/b/c answer is {val}");
            

            json = @"{""x"":{""y"":{""z"":""a""}}}";
            val = getString(json, "x/y/z");
            Console.WriteLine($"x/y/z answer is {val}");

            Console.ReadLine();
        }

        private static string getString(string obj, string keys)
        {
            var keysArr = keys.Split(new[] { '/' }, 2);
            var keyToFind = keysArr[0];
            var val = JsonConvert.DeserializeObject<Dictionary<string, object>>(obj);

            if (keysArr.Length > 1)
            {
                var keyToSearch = keysArr[1];
                return getString(val[keyToFind].ToString(), keyToSearch);
            }
            else
            {
                return val[keyToFind].ToString();
            }
        }
    }
}
