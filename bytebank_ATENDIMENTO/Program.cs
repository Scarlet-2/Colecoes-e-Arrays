﻿using System.Collections;
using bytebank.Modelos.ADMs.Utilitario;
using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos De Sistem de Array (Maluco)

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavara a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }

}

/*
Array amostra = new double[5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
*/

//[5,9][1,8][7,1][10][6,9]
//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                   (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

/*
int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(valores[i]);
}
*/

void TestaArrayDeContasCorrentes()
{
    /*
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        // Lista de (Objetos) Contas Corrente
        new ContaCorrente(874, "4239787-B"),
        new ContaCorrente(874, "4456456-A"),
        new ContaCorrente(874, "7764144-C"),
        
    };
    
    // Passa por cada item 
    for(int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice{i} - Conta:{contaAtual.Conta}");
    }
    */
    
    // Nova forma manual
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes(); 
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A")); 
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B")); 
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C")); 
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C")); 
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C")); 
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    
    // Isso é horivel (PRA QUE FAZER ISSO)
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    /*
    listaDeContas.ExibeLista();
    listaDeContas.Remover(contaDoAndre);
    listaDeContas.ExibeLista();
    */
    
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }
}

TestaArrayDeContasCorrentes();

TestaArrayInt();

TestaBuscarPalavra();

#endregion

ArrayList _listaDeContas = new ArrayList();

void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===1 - Cadastrar Conta      ===");
        Console.WriteLine("===2 - Listar Contas        ===");
        Console.WriteLine("===3 - Remover Conta        ===");
        Console.WriteLine("===4 - Ordenar Contas       ===");
        Console.WriteLine("===5 - Pesquisar Conta      ===");
        Console.WriteLine("===6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }

        void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CONTAS    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe dados da conta ===");
            Console.Write("Número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Infome nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Infome CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Infome Profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);
            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }
    }
    
    void ListarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     LISTA DE CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("... Não há contas cadastradas! ...");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente item in _listaDeContas)
        {
            Console.WriteLine("===  Dados da Conta  ===");
            Console.WriteLine("Número da Conta : " + item.Conta);
            Console.WriteLine("Saldo da Conta : " + item.Saldo);
            Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
            Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
            Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadKey();
        }

    }
}
