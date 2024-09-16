// Matriz
string[,] dados = {
    {"Ralf", "Curitiba"},
    {"Juliana", "Campinas"},
    {"Cleber", "Joinville"},
    {"Marcela", "Londrina"}
};

// Exibir dados
//Console.WriteLine(dados[0,0]);

foreach(string dado in dados)
{
    Console.WriteLine(dado);
}
