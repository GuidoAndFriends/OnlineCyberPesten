using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace PHPrequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "http://harbingerofme.info/GnF/test.php";
            WebClient wc = new WebClient();
            NameValueCollection data = new NameValueCollection();
            data["naam"] = "user";
            data["email"] = "mail";
            byte[] responseBytes = wc.UploadValues(URL, "POST", data);
            string responsefromserver = Encoding.UTF8.GetString(responseBytes);
            Console.WriteLine(responsefromserver);
            Console.ReadKey();
            wc.Dispose();
        }
    }
}



