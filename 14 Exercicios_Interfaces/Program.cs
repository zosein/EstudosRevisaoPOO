using _14_Exercicios_Interfaces;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();


SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvar = new SalvarJson();
salvar.Compactar();

Console.ReadKey();