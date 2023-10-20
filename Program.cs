using Calculator.Divisao;
using Calculator.Multiplicacao;
using Calculator.Soma;
using Calculator.Subtracao;

Menu();

Console.ReadKey();

static void Menu() 
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Qual operação deseja realizar?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("--------------------");
    Console.WriteLine("Selecione uma opção:");
    short res = short.Parse(Console.ReadLine()!);
    
    switch(res) 
    {
        case 1:
            Console.WriteLine($"A soma de {v1} + {v2} = {Soma.Somar(v1, v2)}");
            break;
        case 2:
            Console.WriteLine($"A subtração de {v1} - {v2} = {Subtracao.Subtrair(v1, v2)}");
            break;
        case 3:
            if(v2 == 0)
            {
                Console.WriteLine("Divisão por zero"); 
                Menu();               
            }
            else
            {
                Console.WriteLine($"A divisão de {v1} / {v2} = {Divisao.Dividir(v1, v2)}");                
            }
            break;
        case 4:
            Console.WriteLine($"A multiplicação de {v1} x {v2} = {Multiplicacao.Multiplicar(v1, v2)}");
            break;
        case 5:
            Environment.Exit(0);
            break;
        default: 
            Menu(); 
            break;
    }    
}
Menu();

