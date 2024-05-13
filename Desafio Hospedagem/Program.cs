
using System.Text;
using Desafio_Hospedagem.models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite_premium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite_luxo = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 80);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite_premium);
reserva.CadastrarSuite(suite_luxo);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");



































//using Desafio_Hospedagem.models;
//
//static void main()
//{
//  Console.WriteLine("Sistema de hospedagem");
//  Console.WriteLine("Escolha uma opção: ");
//  string input = Console.ReadLine();
//  int opcao;
//  if (int.TryParse(input, out opcao))
//  {
//    switch (opcao)
//    {
//      case 1:
//        Console.WriteLine("Escolha uma opção: ");
//        Console.WriteLine("1 - Cadastrar Suite");
//        CadastrarSuite();
//        
//        break;
//      case 2:
//        Console.WriteLine("2 - Cadastrar hospede");
//        CadastrarHospede();
//
//
//        break;
//      
//      case 3:
//
//        Console.WriteLine("3 - reservar suites");
//        ReservarSuite();
//        break;
//    
//      case 4:
//        Console.WriteLine("4 - Listar informações");
//        reserva.ObterQuantidadeHospedes();
//      
//      default:
//        Console.WriteLine("Opção inválida!");
//        main();
//        break;
//
//      
//    }
//  }
//  else
//  {
//    Console.WriteLine("Opção inválida!");
//  }
//
//
//  main();
//}
//
//static void CadastrarSuite()
//{
//  Console.WriteLine("Cadastrar Suite");
//  Console.WriteLine("Digite o tipo da suite: ");
//  string tipoSuite = Console.ReadLine();
//  Console.WriteLine("Digite a capacidade da suite: ");
//  string capacidade = Console.ReadLine();
//  Console.WriteLine("Digite o valor da diária: ");
//  string valorDiaria = Console.ReadLine();
//  Suite suite = new Suite(tipoSuite, int.Parse(capacidade), decimal.Parse(valorDiaria));
//}
//
//
//
//static void CadastrarHospede()
//{
//  Console.WriteLine("Cadastrar Hospede");
//  Console.WriteLine("Digite o nome do hospede: ");
//  string nome = Console.ReadLine();
//  Console.WriteLine("Digite o sobrenome do hospede: ");
//  string sobrenome = Console.ReadLine();
//  Pessoa pessoa = new Pessoa(nome, sobrenome);
//}
//
//
//
//static void ReservarSuite()
//{
//  Console.WriteLine("Reservar Suite");
//  Console.WriteLine("Digite o nome do hospede: ");
//  string nome = Console.ReadLine();
//  Console.WriteLine("Digite o sobrenome do hospede: ");
//  string sobrenome = Console.ReadLine();
//  Console.WriteLine("Digite o tipo da suite: ");
//  string tipoSuite = Console.ReadLine();
//  Console.WriteLine("Digite a capacidade da suite: ");
//  string capacidade = Console.ReadLine();
//  Console.WriteLine("Digite o valor da diária: ");
//  string valorDiaria = Console.ReadLine();
//  Console.WriteLine("Digite a quantidade de dias: ");
//  string dias = Console.ReadLine();
//  Pessoa pessoa = new Pessoa(nome, sobrenome);
//  Suite suite = new Suite(tipoSuite, int.Parse(capacidade), decimal.Parse(valorDiaria));
//  Reserva reserva = new Reserva();
//  reserva.CadastrarHospedes(new List<Pessoa> { pessoa });
//  reserva.CadastrarSuite(suite);
//  reserva.DiasReservados = int.Parse(dias);
//  Console.WriteLine($"O valor total da reserva é: {reserva.CalcularValorDiaria()}");
//  
//}
//
//
//
//main();
//














