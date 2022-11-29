using ClientLab.Classes;

// CADASTRANDO PF
PessoaFisica novaPf = new PessoaFisica();
    // ENDERECO PF
Endereco endPf = new Endereco();
endPf.Logradouro = "Rua São Pedro";
endPf.Numero = 253;
endPf.IsComercial = false;
    // DADOS DA PF
novaPf.Nome = "Maria Rita";
novaPf.Cpf = "846.775.550-44";
novaPf.DataNascimento ="24/02/1970";
novaPf.Rendimento = 2000;
novaPf.Endereco = endPf;

// CRIA VARIÁVEL PARA RECEBER MÉTODOS DA PF

PessoaFisica metodosPf = new PessoaFisica();

// EXIBIR PF
 Console.WriteLine($"*************Pessoa Física*************");

Console.WriteLine(@$"
Nome: {novaPf.Nome}
CPF: {novaPf.Cpf}
Data Nascimento: {novaPf.DataNascimento}
Maior de idade?: {metodosPf.ValidarDataNasc(novaPf.DataNascimento)}
Endereço: {novaPf.Endereco.Logradouro}
Número: {novaPf.Endereco.Numero}
Endereço Comercial: {novaPf.Endereco.IsComercial}
Rendimento Bruto: R$ {novaPf.Rendimento},00
Rendimento Liquido: R$ {metodosPf.PagarImposto(novaPf.Rendimento)},00
");

// CADASTRAR PJ
PessoaJuridica novaPj = new PessoaJuridica();

    // ENDERECO PJ
Endereco endPj = new Endereco();
endPj.Logradouro = "Rua da José Bonifácio";
endPj.Numero = 500;
endPj.IsComercial = true;
    // DADOS PJ
novaPj.Nome = "José Carlos";
novaPj.RazaoSocial = "Consultoria em TI";
novaPj.Cnpj = "24.382.463/0001-23";
novaPj.Endereco = endPj;
novaPj.Rendimento = 100000;

// CRIA VARIÁVEL PARA RECEBER MÉTODOS DA PF
PessoaJuridica metodosPj = new PessoaJuridica();

// EXIBIR PJ
Console.WriteLine($"*************Pessoa Jurídica************* ");

Console.WriteLine(@$"
Razão Social: {novaPj.RazaoSocial}
Nome Representante: {novaPj.Nome}
CNPJ: {novaPj.Cnpj}
CNPJ é válido? {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.Logradouro}
Número: {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.IsComercial}
Rendimento Bruto: R$ {novaPj.Rendimento},00
Rendimento Líquido: R$ {metodosPj.PagarImposto(novaPj.Rendimento)},00
");
