using iTaaS;


Console.WriteLine("Hello Welcome to iTaaS System - aplicativo de console .NET 6.0");
var extrac = new ExtractLog();
Console.WriteLine("Extraindo log MINHA CDN");
extrac.ExtraiLog();
Console.WriteLine("Convertendo CDN");
var ReadFile = new ConvertLog();
ReadFile.ConverterLog();
Console.WriteLine("Novo Arquivo de Log Padronizado padrão AGORA_LOG disponivel no diretório de saida - OutPut-agora ");

Console.WriteLine("fim do aplicativo de console .NET 6.0 ");

Console.ReadKey();
