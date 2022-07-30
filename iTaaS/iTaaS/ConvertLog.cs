using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace iTaaS
{
    public class ConvertLog
    {
        public void ConverterLog()
        {
#pragma warning disable SYSLIB0014 // O tipo ou membro é obsoleto
            string text = System.IO.File.ReadAllText(@"E:\Agile\iTaaS\Download\minhacdn\MINHA_CDN.txt");
            text.Split("|");
            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("lendo arquivo CDN {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"E:\Agile\iTaaS\Download\minhacdn\MINHA_CDN.txt");
            StreamWriter x;

            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
           var CaminhoNome = @"E:\Agile\iTaaS\OutPut\agora\AGORA_LOG.txt";

            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            if (File.Exists(CaminhoNome) == true)
            {
                Console.WriteLine("OK arquivo existe");
            }
            else
            {
                x = File.CreateText(CaminhoNome);
                x.Close();
            }

            

            System.Console.WriteLine("Converting Logs Padrão AGORA = ");
            foreach (string line in lines)
            {
                StreamWriter arquivo = new StreamWriter(@"E:\Agile\iTaaS\OutPut\agora\AGORA_LOG.txt", true, Encoding.ASCII);
                var provedor = "MINHA CDN";
               
                string[] parts = line.Split(' ' , '|' );
                parts[3].Replace('/', ' ');
                Console.WriteLine(parts[3]);
                

                Console.WriteLine("\t" + provedor + " " + parts[3] + " " + parts[1] + " " +  parts[4] + " " + parts[6] + " " + parts[0] + " " + parts[2]);
                var textoarquivo = provedor + " " + parts[3] + " " + parts[1] + " " + parts[4] + " " + parts[6] + " " + parts[0] + " " + parts[2];
                arquivo.WriteLine(textoarquivo);
                arquivo.Close();
               
            }
           
            
        }
    
        
    }
}
