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

TestArray();

