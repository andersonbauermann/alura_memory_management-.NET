using System.Diagnostics;
using UsuarioLib;

Usuario usuario = 
    new ("Anderson", "anderson@email.com",new List<string>() {"12345678"});

//Usuario usuario2 =
//    new ("Naila", "naila@email.com", new List<string>() {"87654321"});

//usuario.ExibeTelefones();
//usuario.PadronizaTelefones();
//usuario.ExibeTelefones();
//usuario.ExibeChaveDeAcesso();
//Console.WriteLine("---------");
//usuario2.ExibeTelefones();
//usuario2.PadronizaTelefones();
//usuario2.ExibeTelefones();
//usuario2.ExibeChaveDeAcesso();

//Stopwatch tempoProcessamento = new();
//tempoProcessamento.Start();
//usuario.ChaveDeAcesso.Insert(0, Guid.NewGuid());
//for (int i = 0; i < 100000; i++)
//{
//    usuario.ChaveDeAcesso.Insert(1, Guid.NewGuid());
//}
//tempoProcessamento.Stop();
//Console.WriteLine($"TEMPO DE PROCESSAMENTO <List>: {tempoProcessamento.Elapsed.TotalMilliseconds}");

//Stopwatch tempoProcessamentoLinked = new();
//tempoProcessamentoLinked.Start();
//usuario.ChaveDeAcessoLinked.AddFirst(Guid.NewGuid());
//for (int i = 0; i < 100000; i++)
//{
//    usuario.ChaveDeAcessoLinked.AddAfter(usuario.ChaveDeAcessoLinked.First, Guid.NewGuid());
//}
//tempoProcessamentoLinked.Stop();
//Console.WriteLine($"TEMPO DE PROCESSAMENTO <LinkedList>: {tempoProcessamentoLinked.Elapsed.TotalMilliseconds}");

//Console.WriteLine(coordenada);

//Stopwatch sw = new();
//sw.Start();

//for (int i = 0; i < 1000000000; i++)
//{
//    Coordenada coordenada = new(123.456, -123.678);
//    var latitude = coordenada.Latitude;
//    var longitude = coordenada.Longitude;
//}

//sw.Stop();
//Console.WriteLine(sw.Elapsed.TotalMilliseconds);

//FormDto dto = new("Anderson", "12345678912", 29, "Dev");

//FormDto dto2 = new();
//dto2.Nome = "Anderson";
//dto2.Idade = 29;
//dto2.Cargo = "Dev";
//dto2.Cpf = "12345678912";

//Console.WriteLine(dto == dto2);

Stopwatch sw = new();

sw.Start();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoClass dto = new FormularioDtoClass("Anderson", "11111111111", "Programador", 29);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo class: {sw.Elapsed.TotalMilliseconds}");


sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecord dto = new FormularioDtoRecord("Anderson", "11111111111", "Programador", 29);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoStruct dto = new FormularioDtoStruct("Anderson", "11111111111", "Programador", 29);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo struct: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecordStruct dto = new FormularioDtoRecordStruct("Anderson", "11111111111", "Programador", 29);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record struct: {sw.Elapsed.TotalMilliseconds}");
