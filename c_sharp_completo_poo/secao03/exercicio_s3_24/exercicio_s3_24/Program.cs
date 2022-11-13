using System.Globalization;


/*
     exercicio 01
     Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
     mensagem explicativa, conforme exemplos
*/



Console.WriteLine("Entrada******");
Console.WriteLine("Entre com o primeiro valor: ");
int value01 = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o segundo valor: ");
int value02 = int.Parse(Console.ReadLine());

Console.WriteLine("Saída********");
Console.WriteLine(value01+value02);


/*
    exercicio 02 
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
    casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159
*/

double PI = 3.14159;
double area;
double raio;

Console.WriteLine("Entrada******");
Console.WriteLine("Entre com o valor do raio: ");
raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Saída********");
area = PI * Math.Pow(raio, 2);
Console.WriteLine("Valor da area é: " + area.ToString("F4", CultureInfo.InvariantCulture));



/*
    Exercício 03
    Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
    de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
*/

Console.WriteLine("Entrada******");
Console.WriteLine("Entre com o primeiro valor: ");
int valor01 = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o segundo valor: ");
int valor02 = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o terceiro valor: ");
int valor03 = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o quarto valor: ");
int valor04 = int.Parse(Console.ReadLine());

int diferenca = (valor01 * valor02) - valor03 * valor04;

Console.WriteLine("Saída********");
Console.WriteLine("Diferença é: " + diferenca);


/*
    Exercício 04
    Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
    hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
    decimais.
*/

Console.WriteLine("Entrada******");
Console.WriteLine("Entre com o numero do funcionário: ");
int employee = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o numero do horas trabalhadas: ");
double hours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o numero do funcionário: ");
double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double salary = hours * valuePerHour;
Console.WriteLine("Saída********");
Console.WriteLine("O Funcionário: " + employee + " teve o salário: U$" + salary.ToString("F2", CultureInfo.InvariantCulture));


/*
    Exercício 05
    Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
    código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

Console.WriteLine("Entrada******");
Console.WriteLine("Entre com o codigo do produto 01, com a quantidade de peças e com o valor da peça: ");
string[] order01 = Console.ReadLine().Split(' ');
Console.WriteLine("Entre com o codigo do produto 02, com a quantidade de peças e com o valor da peça: ");
string[] order02 = Console.ReadLine().Split(' ');
int piece01 = int.Parse(order01[1]);
double price01 = double.Parse(order01[2], CultureInfo.InvariantCulture);
int piece02 = int.Parse(order02[1]);
double price02 = double.Parse(order02[2], CultureInfo.InvariantCulture);
double total = (price01 * piece01) + (price02 * piece02);
Console.WriteLine("Saída********");
Console.WriteLine("Valor a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));



/*
    Exercício 06
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
    mostre: 
        a) a área do triângulo retângulo que tem A por base e C por altura. 
        b) a área do círculo de raio C. (pi = 3.14159) 
        c) a área do trapézio que tem A e B por bases e C por altura. 
        d) a área do quadrado que tem lado B. 
        e) a área do retângulo que tem lados A e B.
 */

Console.WriteLine("Entrada******");
Console.WriteLine("Entre com os valores A, B e C: ");
string[] values = Console.ReadLine().Split(' ');
double a = Double.Parse(values[0], CultureInfo.InvariantCulture);
double b = Double.Parse(values[1], CultureInfo.InvariantCulture);
double c = Double.Parse(values[2], CultureInfo.InvariantCulture);
double triangulo = (a * c) / 2;
double circulo = PI * Math.Pow(c, 2);
double trapezio = (a + b) * c / 2;
double quadrado = b * b;
double retangulo = a * b;

Console.WriteLine("Saída********");
Console.WriteLine("Area do TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Area do CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Area do TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Area do QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Area do RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

