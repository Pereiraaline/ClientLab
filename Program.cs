using ClientLab.Classes;


// CRIA VARIÁVEL PARA RECEBER MÉTODOS DA PF
PessoaFisica metodosPf = new PessoaFisica();

// CRIA VARIÁVEL PARA RECEBER MÉTODOS DA PF
PessoaJuridica metodosPj = new PessoaJuridica();


// CABEÇALHO DO SISTEMA

Console.WriteLine(@$"
+====================================================+
|        Bem vindo ao sistema de cadastro de         |
|            Pessoas Físicas e Jurídicas             |
+====================================================+
");

Console.WriteLine();
Util.Loading("Iniciando o sistema", 300, 3, ConsoleColor.DarkGreen, ConsoleColor.DarkGray);

Console.WriteLine();

//MENU DO SISTEMA
string? opcao;

do
{
    Console.WriteLine(@$"
+====================================================+
|          Escolha uma das opções abaixo             |
| ---------------------------------------------------|
|               1 - Pessoa Física                    |
|               2 - Pessoa Jurídica                  |
|                                                    |
|               0 - Sair                             |
+====================================================+
");

    // escolhendo opção dentro do menu
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            Console.WriteLine($"Obrigado por utilizar nosso sistema! :) ");
            Console.WriteLine();

            Util.Loading("Finalizando o sistema", 300, 5, ConsoleColor.DarkGreen, ConsoleColor.DarkGray);
            Console.WriteLine();
            Console.WriteLine();

            break;

        case "1":
            Console.Clear();

            string? opcaoPf;

            // LAÇO DO SUB-MENU
            do
            {
                // SUB-MENU PARA PESSOA FÍSICA
                Console.WriteLine(@$"
+====================================================+
|          Escolha uma das opções abaixo             |
| ---------------------------------------------------|
|            1 - Cadastrar Pessoa Física             |
|            2 - Listar Pessoa Física                |
|                                                    |
|            0 - Voltar ao menu anterior             |
+====================================================+
");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();
                        // CADASTRANDO PF
                        PessoaFisica novaPf = new PessoaFisica();
                        // ENDERECO PF
                        Endereco endPf = new Endereco();
                        Console.WriteLine($"Digite o Logradouro: ");
                        endPf.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número: ");
                        endPf.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O endereço é comercial? S/N ");
                        string? endComercial = Console.ReadLine();

                        if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                        {
                            endPf.IsComercial = true;
                        }
                        else
                        {
                            endPf.IsComercial = false;
                        }

                        // DADOS DA PF
                        Console.WriteLine($"Digite o nome da pessoa física: ");
                        novaPf.Nome = Console.ReadLine();
                        Console.WriteLine($"Digite o CPF da pessoa física: ");
                        novaPf.Cpf = Console.ReadLine();
                        Console.WriteLine($"Digite a Data de Nascimento da pessoa física: (ex: dd/mm/aaaa) ");
                        novaPf.DataNascimento = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da pessoa física: ");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        novaPf.Endereco = endPf;

                        //ADICIONA NO ARQUIVO TXT DE PESSOAS FÍSICAS
                    
                        using (StreamWriter arquivoPf = new StreamWriter("./PessoaFisica.txt", true))
                        {
                            arquivoPf.WriteLine($"{novaPf.Nome},{novaPf.Cpf},{novaPf.DataNascimento},{novaPf.Endereco.Logradouro},{novaPf.Endereco.Numero},{novaPf.Endereco.IsComercial},{novaPf.Rendimento}");
                        }

                        Console.WriteLine($"Pessoa Física cadastrada com sucesso!");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine($"******** Início da Lista de Pessoas Físicas********");

                        //LE OS DADOS NO ARQUIVO TXT DE PESSOAS FÍSICAS
                        using (StreamReader arquivoPf = new StreamReader("./PessoaFisica.txt"))
                        {
                            string? linhaPessoa;
                            while ((linhaPessoa = arquivoPf.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split(",");
                                Console.WriteLine(@$"
Nome: {dadosPessoa[0]}
CPF: {dadosPessoa[1]}
Data Nascimento: {dadosPessoa[2]}
Endereço: {dadosPessoa[3]}
Número: {dadosPessoa[4]}
Rendimento Bruto: R$ {dadosPessoa[6]},00
Rendimento Liquido: R$ {metodosPf.PagarImposto(float.Parse(dadosPessoa[6]))},00
");

                                Console.WriteLine("Maior de idade ?: " + (metodosPf.ValidarDataNasc(dadosPessoa[2]) ? "Sim" : "Não"));
                                Console.WriteLine("Endereço Comercial: " + (Boolean.Parse(dadosPessoa[5]) ? "Sim" : "Não"));
                            }
                        }

                        Console.WriteLine($"******** Fim da Lista de Pessoas Físicas********");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltar ao menu anterior");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção Inválida");
                        Console.ResetColor();
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                }
            } while (opcaoPf != "0");

            Util.ParadaNoConsole("Tecle <ENTER> para continuar!");
            Console.Clear();
            break;
        case "2":
            Console.Clear();

            string? opcaoPj;

            // LAÇO DO SUB-MENU
            do
            {
                // SUB-MENU PARA PESSOA FÍSICA
                Console.WriteLine(@$"
+====================================================+
|          Escolha uma das opções abaixo             |
| ---------------------------------------------------|
|            1 - Cadastrar Pessoa Jurídica           |
|            2 - Listar Pessoa Jurídica              |
|                                                    |
|            0 - Voltar ao menu anterior             |
+====================================================+
");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        Console.Clear();
                        // CADASTRAR PJ
                        PessoaJuridica novaPj = new PessoaJuridica();
                        // ENDERECO PJ
                        Endereco endPj = new Endereco();
                        Console.WriteLine($"Digite o Logradouro: ");
                        endPj.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número: ");
                        endPj.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O endereço é comercial? S/N ");
                        string? endComercial = Console.ReadLine();

                        if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                        {
                            endPj.IsComercial = true;
                        }
                        else
                        {
                            endPj.IsComercial = false;
                        }

                        // DADOS DA PJ
                        Console.WriteLine($"Digite a Razão Social da pessoa jurídica: ");
                        novaPj.RazaoSocial = Console.ReadLine();
                        Console.WriteLine($"Digite o CNPJ da pessoa jurídica: ");
                        novaPj.Cnpj = Console.ReadLine();
                        Console.WriteLine($"Digite o nome do Representante da pessoa jurídica: ");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da pessoa jurídica: ");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        novaPj.Endereco = endPj;

                        //ADICIONA NO ARQUIVO TXT PESSOAS JURÍDICAS

                        using (StreamWriter arquivoPj = new StreamWriter("./PessoaJuridica.txt", true))
                        {
                            arquivoPj.WriteLine($"{novaPj.RazaoSocial},{novaPj.Nome},{novaPj.Cnpj},{novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero},{novaPj.Endereco.IsComercial},{novaPj.Rendimento}");
                        }


                        Console.WriteLine($"Pessoa Jurídica cadastrada com sucesso!");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine($"******** Início da Lista de Pessoas Jurídicas ********");
                        using (StreamReader arquivoPj = new StreamReader("./PessoaJuridica.txt"))
                        {
                            string? linhaPessoa;
                            while ((linhaPessoa = arquivoPj.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split(",");
                                Console.WriteLine(@$"
Razão Social: {dadosPessoa[0]}
Nome Representante: {dadosPessoa[1]}
CNPJ: {dadosPessoa[2]}
Endereço: {dadosPessoa[3]}
Número: {dadosPessoa[4]}
Rendimento Bruto: R$ {dadosPessoa[6]},00
Rendimento Líquido: R$ {metodosPj.PagarImposto(float.Parse(dadosPessoa[6]))},00
");

                                Console.WriteLine("CNPJ é válido ?: " + (metodosPj.ValidarCnpj(dadosPessoa[2]) ? "Sim" : "Não"));
                                Console.WriteLine("Endereço Comercial: " + (Boolean.Parse(dadosPessoa[5]) ? "Sim" : "Não"));

                            }
                        }
                      
                        Console.WriteLine($"******** Fim da Lista de Pessoas Jurídicas ********");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltar ao menu anterior");
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção Inválida");
                        Console.ResetColor();
                        Util.ParadaNoConsole("Tecle <Enter> para continuar");
                        break;

                }
            } while (opcaoPj != "0");

            Util.ParadaNoConsole("Tecle <ENTER> para continuar!");
            Console.Clear();
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inválida");
            Console.ResetColor();
            Util.ParadaNoConsole("Tecle <ENTER> para continuar!");
            break;
    }
} while (opcao != "0");
