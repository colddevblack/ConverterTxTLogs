using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace iTaaS
{
    public class ExtractLog
    {
        public void ExtraiLog()
        {
#pragma warning disable SYSLIB0014 // O tipo ou membro é obsoleto
            WebClient downloader = new WebClient();
#pragma warning restore SYSLIB0014 // O tipo ou membro é obsoleto
            downloader.DownloadFile("https://s3.amazonaws.com/uux-itaas-static/minha-cdn-logs/input-01.txt", @"E:\Agile\iTaaS\Download\minhacdn\MINHA_CDN.txt");
        }
    
        
    }
}
