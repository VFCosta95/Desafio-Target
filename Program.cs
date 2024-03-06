Console.WriteLine("Hello, World!");

// Inverter Strings - Exercicio 5 
/*
Console.Write("Digite a string: "); 

string inputString = Console.ReadLine(); // Digitar a string.
char[] caracteres = inputString.ToCharArray(); // Converter a string para um array de caracteres.
Array.Reverse(caracteres); // Inverte os caracteres no array.
string stringInvertida = new string(caracteres); // Nova string a partir dos caracteres invertidos.

Console.WriteLine("String invertida: " + stringInvertida);
*/

/*-----------------------------------------------------------------------------------------------------*/

// Sem a função Reverse()

Console.Write("Digite uma string: ");

string inputString = Console.ReadLine();
string stringInvertida = InverterString(inputString);

Console.WriteLine("String invertida: " + stringInvertida);
    

static string InverterString(string input){
    
    if (string.IsNullOrEmpty(input))
    {
        return input; // Verifica se a string de entrada é null
    }

    char[] caracteres = input.ToCharArray(); // Converter a string para um array
    int inicio = 0;
    int fim = input.Length - 1;

    while (inicio < fim) // Percorre a string invertendo os caracteres
    {
        // Troca os caracteres de posição
        char temp = caracteres[inicio];
        caracteres[inicio] = caracteres[fim];
        caracteres[fim] = temp;

        // Move os índices para o próximo par de caracteres
        inicio++;
        fim--;
    }

    string stringInvertida = new string(caracteres); // Cria uma nova string a partir dos caracteres invertidos

    return stringInvertida;
}

