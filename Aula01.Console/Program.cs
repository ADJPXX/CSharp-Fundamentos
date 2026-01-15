/*
//AULA 1 - ESCREVENDO NA TELA
Console.WriteLine("Nome: Adriel, Idade: 20. Eu estou aprendendo C# para me tornar um programador profissional!");
Console.WriteLine("10");
Console.WriteLine("20");
Console.WriteLine("30");

//AULA 2 - OPERADOR LÓGICO E INSERINDO VARIAVEL NA STRING
string meunome = "Adriel";
int minhaidade = 20;
bool estudar = true;

Console.WriteLine("Nome: " + meunome);
Console.WriteLine("Idade: " + minhaidade);
Console.WriteLine($"Estudando C#: {estudar}");

int a = 10;
int b = 20;
int minhasoma = a + b;

Console.WriteLine($"Resultado: {minhasoma}");

//AULA 3 - LENDO INPUT
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá {nome}, você tem {idade} anos.");

Console.Write("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());
int soma = numero1 + numero2;
int subtracao = numero1 - numero2;
int multiplicacao = numero1 * numero2;

Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}\nA Subtração de {numero1} e {numero2} é: {subtracao}\nA multiplicação de {numero1} e {numero2} é: {multiplicacao}");



//AULA 4 - TRY/CATCH
try
{
    Console.Write("Digite sua idade: ");
    int idadeTryCatch = int.Parse(Console.ReadLine());
    Console.WriteLine($"Sua idade: {idadeTryCatch}");
}
catch
{
    Console.WriteLine("Idade inválida! Digite apenas números.");
}

try
{
    Console.Write("Digite o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"A soma de {numero1} e {numero2} é: {numero1 + numero2}");
}
catch
{
    Console.WriteLine("Erro! Digite um número válido.");
}


//AULA 5 - IF, ELSE, ELSE IF
Console.Write("Digite um número: ");
string numero = Console.ReadLine();

bool valido = int.TryParse(numero, out int resultado);
if (valido)
{
    if (resultado < 10)
    {
        Console.WriteLine($"O número {resultado} é MENOR que 10");
    }
    else
    {
        Console.WriteLine($"O número {resultado} é MAIOR que 10");
    }
}
else
{
    Console.WriteLine("DIGITE UM NÚMERO VÁLIDO.");
}

Console.Write("Digite o primeiro número: ");
string numero1 = Console.ReadLine();

Console.Write("Digite o segundo número: ");
string numero2 = Console.ReadLine();

bool valido1 = int.TryParse(numero1, out int resultado1);
bool valido2 = int.TryParse(numero2, out int resultado2);

if (valido1 && valido2)
{
    if (resultado1 < resultado2)
    {
        Console.WriteLine($"O número {resultado2} é MAIOR que o número {resultado1}");
    }
    else
    {
        Console.WriteLine($"O número {resultado1} é MAIOR que o número {resultado2}");
    }
}
else
{
    Console.WriteLine("Digite um número válido");
}


//AULA 6 - DO WHILE
bool valido;

do
{
    Console.Write("Digite um número: ");
    valido = int.TryParse(Console.ReadLine(), out int numero);
    if (!valido)
    {
        Console.WriteLine("ERRO! DIGITE UM NÚMERO VÁLIDO.");
    }
    else
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("Seu número é PAR");
        }
        else
        {
            Console.WriteLine("Seu número é IMPAR");
        }
    }
    
} while (!valido);


//AULA 7 - FOR
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);
}


//AULA 8 - ARRAYS
int[] numeros = { 10, 20, 30, 40, 50 };
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

int[] numeros = { 10, 20, 30, 40, 50 };
int soma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    soma += numeros[i];
}
Console.WriteLine($"A soma dos números é: {soma}");


//AULA 9 - FOREACH
int[] numeros =  {10, 20, 30, 40, 50};

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

int[] numeros = {13, 20, 30, 40, 50,};

int soma = 0;
double media = 0;

foreach (int numero in numeros)
{
    soma += numero;
}
media = (double)soma / numeros.Length;

Console.WriteLine($"A média dos números é: {media:F2}");


//AULA 10 - LISTAS DINÂMICAS
List<int> numeros = new List<int>();

int numeroUsuario;
int soma = 0;
int maiorNumero;
int menorNumero;
double media;

while(numeros.Count < 5)
{
    Console.Write($"Digite o número {numeros.Count + 1}: ");
    
    if (int.TryParse(Console.ReadLine(), out numeroUsuario))
    {
        numeros.Add(numeroUsuario);
    }
}
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
    soma += numero;
}
media = (double)soma / numeros.Count;
maiorNumero = numeros.Max();
menorNumero = numeros.Min();

Console.WriteLine($"Soma: {soma}\nMédia: {media:F2}\nMaior número: {maiorNumero}\nMenor número: {menorNumero}");


//AULA 11 - MÉTODOS
static bool NumeroPar(int numero)
{
    return numero % 2 == 0;
}

List<int> numeros = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(CalcularMedia(numeros));

static int MaiorNumero(List<int> numeros)
{
    int maiornumero = numeros[0];
    
    foreach(int numero in numeros)
    {
        if (numero > maiornumero)
        {
            maiornumero = numero;
        }
    }

    return maiornumero;
}

static double CalcularMedia(List<int> numeros)
{
    int soma = 0;
    double media;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    media = (double)soma / numeros.Count;
    return media;
}


//AULA 12 - CLASSES E ORIENTAÇÃO A OBJETOS
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Adriel";
pessoa.Idade = 20;

pessoa.Apresentar();

class Pessoa
{
    public string Nome
    {
        get;
        set;
    }

    private int idade;
    
    public int Idade
    {
        get { return idade;}
        set
        {
            if (value >= 0 && value <= 130)
            {
                idade = value;
            }
        }
    }
    
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }
    
}

*/
//AULA 13 - CONSTRUTORES
Produto p = new Produto("Teclado", 150, 20);
p.Vender(3);
Console.WriteLine(p.Estoque);

class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int Estoque { get; private set; }

    public Produto(string nome, double preco, int estoque)
    {
        if (preco < 0)
            throw new Exception("PREÇO INVALIDO.");

        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("NOME INVÁLIDO.");
        
        if (estoque < 0)
            throw new Exception("ESTOQUE INVÁLIDO.");

        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public void Vender(int quantidade)
    {
        if (quantidade <= 0)
            return;
        if (quantidade > Estoque)
            return;
        Estoque -= quantidade;
    }
}
