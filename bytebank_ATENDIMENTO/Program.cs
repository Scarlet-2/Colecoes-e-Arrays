Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestArray()
{
    int[] numeros = new int[5];
    numeros[0] = 23;
    numeros[1] = 15;
    numeros[2] = 10;
    numeros[3] = 2;
    numeros[4] = 300;

    //Console.WriteLine($"Tamanho de Array = {numeros.Length}");

    int contador = 0;
    int final = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        contador = contador + numeros[i];
        // contador += numeros[i];
    }
    
    // Inciar e declarar arrays
    // string [] palavras= new string[5] {"André","Jose","Andressa","Neia","Sarah"}

    contador /= numeros.Length;
    Console.WriteLine(contador);
}

void TentarBuscarPalavra()
{
    string[] arraydePalavras = new string[5];
    for (int i = 0; i < arraydePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arraydePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    string busca = Console.ReadLine();

    foreach (string palavra in arraydePalavras)
    {
        // Versão mais complexa
        /*
        int indexo = Array.IndexOf(arraydePalavras, palavra);
        if (palavra.ToLower() == busca.ToLower())
        {
            Console.WriteLine($"Voçê digitiou {busca} e foi achada {palavra} e o indexo da palavra é {indexo}.");
            break;
        }
        */

        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
        /*
        else
        {
            Console.WriteLine("Palavra não encontrada");
        }
        */
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//[5,9][1,8][7,1][10][6,9]
TestaMediana(amostra);

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }
    
    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]
    
    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :(numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
