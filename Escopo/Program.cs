// Declaração e inicialização de um array de inteiros com alguns números
int[] numbers = { 4, 8, 15, 16, 23, 42 };

// Declaração de uma variável para armazenar o total da soma dos números do array
int total = 0;

// Declaração de uma variável booleana para verificar se o número 42 foi encontrado
bool found = false;

// Loop foreach para iterar por cada número no array 'numbers'
foreach (int number in numbers)
{
    // Adiciona o valor do número atual à variável 'total'
    total += number;
    
    // Verifica se o número atual é igual a 42
    if (number == 42)
        // Se o número for 42, define a variável 'found' como verdadeira
        found = true;
}

// Após o loop, verifica se o número 42 foi encontrado no array
if (found)
    // Se 'found' for verdadeiro, imprime uma mensagem indicando que o número 42 foi encontrado
    Console.WriteLine("Set contains 42");

// Imprime o valor total da soma de todos os números no array
Console.WriteLine($"Total: {total}");
