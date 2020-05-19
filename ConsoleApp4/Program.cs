using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Backup backup = new Backup();

            //while (true)
            //{
            //    backup.RunAsync();
            //}

            string date = DateTime.Now.ToString("dd/MM/yyy_HH/mm/ss");

            //backup.FullBackUp(@"C:\Data", @"D:\Backup\" + "full_" + date, true);

            backup.DiffBackUp(@"C:\Data", @"D:\Backup\" + "diff_" + date, true);  

            //backup.number();

            Console.ReadLine();

            
            







            
        }
        
        
    }       
}






    

