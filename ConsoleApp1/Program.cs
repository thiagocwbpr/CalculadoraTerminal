

Menu();

static void Menu() {

    Console.Clear();
    
Console.WriteLine("\nCALCULADORA DE TERMINAL\n");
Console.WriteLine("1 - SOMA");
Console.WriteLine("2 - SUBTRAÇÃO");
Console.WriteLine("3 - MULTIPLICAÇÃO");
Console.WriteLine("4 - DIVISÃO");
Console.WriteLine("5 - SAIR");
Console.Write("\nSELECIONE UMA DAS OPÇÕES NUMÉRICAS ACIMA: ");

    Console.ReadKey();

}

static void soma() {
    Console.Clear();
    Console.WriteLine(" \nVOCÊ DESEJA REALIZAR UMA SOMA \n");
    Console.Write("Digite o primeiro numero a ser calculado: \n");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo numero a ser calculado: \n");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n1 + n2;

    Console.WriteLine($"O resultado da soma entre {n1} e {n2} é : {n3}\n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}