using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HangfireMVC.Models
{
    public class Jobs
    {
        public void CreateFile()
        {
            var guid = Guid.NewGuid().ToString().Substring(0, 8);

            File.WriteAllText(
              $"C:/Temp/{guid}.txt",
              DateTime.UtcNow.AddHours(8).ToString());
        }

        public void CreateFile2()
        {
            var guid = Guid.NewGuid().ToString().Substring(0, 8);

            File.WriteAllText(
              $"C:/Temp/{guid}.txt",
               DateTime.UtcNow.AddHours(8).ToString());
        }
    }
}