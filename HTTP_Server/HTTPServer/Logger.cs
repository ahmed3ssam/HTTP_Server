using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        //static StreamWriter sr = new StreamWriter("log.txt");
        public static void LogException(Exception ex)
        {
            //FileStream fileStream = new FileStream(@"C:\Template[2021-2022]\HTTPServer\bin\Debug\log.txt", FileMode.OpenOrCreate);
            // TODO: Create log file named log.txt to log exception details in it
            StreamWriter file_log = new StreamWriter("log.txt");
            //Datetime:
            //message:
            // for each exception write its details associated with datetime 
            file_log.WriteLine("ExceptionMessage: " + ex.Message+" "+"Date: "+ DateTime.Now.ToString());
            file_log.Close();
        }
    }
}
