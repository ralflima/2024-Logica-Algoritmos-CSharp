// Variáveis
double valor = 500;
string pagamento = "a prazo";

// Condicional
if(valor >= 100 && pagamento == "à vista")
{
    Console.WriteLine($"Desconto de 10%! Total a pagar R${valor*0.9}");
}
else
{
    Console.WriteLine($"O total da compra é R${valor}");
}

