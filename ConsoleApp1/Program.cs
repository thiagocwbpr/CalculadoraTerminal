using System.Globalization;

Menu();

static void Menu() {

    Console.Clear();
    
    Console.WriteLine("\nCALCULADORA DE TERMINAL\n");
    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAÇÃO");
    Console.WriteLine("3 - MULTIPLICAÇÃO");
    Console.WriteLine("4 - DIVISÃO");
    Console.WriteLine("5 - PORCENTAGEM");
    Console.WriteLine("6 - SAIR");
    Console.Write("\nSELECIONE UMA DAS OPÇÕES NUMÉRICAS ACIMA: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao) {
        case 1:
            soma();
            break;
        case 2:
            subtracao();
            break;
        case 3:
            multiplicacao();
            break;
        case 4:
            divisao();
            break;
        case 5:
            porcentagem();
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("\n\nObrigado por utilizar a calculadora de terminal! Até a próxima!");
            break;
            System.Environment.Exit(0);
        default:
            Menu();
            break;
    }

    Console.ReadKey();

}
static void soma() {
    Console.Clear();
    Console.Write(" \nVOCÊ DESEJA REALIZAR UMA SOMA \n\n");
    Console.Write("\nDigite o primeiro numero a ser calculado: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("\nDigite o segundo numero a ser calculado: ");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n1 + n2;

    Console.WriteLine($"\n\nO resultado da soma entre {n1} e {n2} é : {n3}\n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}
static void subtracao() {
    Console.Clear();
    Console.Write(" \nVOCÊ DESEJA REALIZAR UMA SUBTRAÇÃO \n\n");
    Console.Write("\nDigite o primeiro numero a ser calculado: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("\nDigite o segundo numero a ser calculado: ");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n1 - n2;

    Console.WriteLine($"\n\nO resultado da subtração entre {n1} e {n2} é : {n3}\n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}
static void multiplicacao() {
    Console.Clear();
    Console.Write(" \nVOCÊ DESEJA REALIZAR UMA MULTIPLICAÇÃO \n\n");
    Console.Write("\nDigite o primeiro numero a ser calculado: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("\nDigite o segundo numero a ser calculado: ");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n1 * n2;

    Console.WriteLine($"\n\nO resultado da multiplicação entre {n1} e {n2} é : {n3}\n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}
static void divisao() {
    Console.Clear();
    Console.Write(" \nVOCÊ DESEJA REALIZAR UMA DIVISÃO \n\n");
    Console.Write("\nDigite o primeiro numero a ser calculado: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("\nDigite o segundo numero a ser calculado: ");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n1 / n2;

    Console.WriteLine($"\n\nO resultado da divisão entre {n1} e {n2} é : {n3}\n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}
static void porcentagem() {
    Console.Clear();
    Console.Write(" \nVOCÊ DESEJA REALIZAR UMA PORCENTAGEM \n\n");
    Console.Write("\nDigite o valor a ser calculado R$: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("\nDigite a porcentagem que deseja calcular %: ");
    float n2 = float.Parse(Console.ReadLine());

    float n3 = n2 * n1;
    float n4 = n3 / 100;

    Console.WriteLine($"\n\n {n2}% de R${n1.ToString("F2", CultureInfo.InvariantCulture)} Reais é : R${n4.ToString("F2",CultureInfo.InvariantCulture)} Reais \n");
    Console.Write("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Menu();
}