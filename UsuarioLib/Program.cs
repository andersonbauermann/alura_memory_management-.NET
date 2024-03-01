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

Coordenada coordenada = new(123.456, -123.678);
Console.WriteLine(coordenada);