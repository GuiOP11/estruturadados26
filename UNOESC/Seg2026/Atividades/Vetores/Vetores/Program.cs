Console.WriteLine("Olá, Mundão!");

// Comentário de uma linha
/*
comen mult linhas
*/

// Alguns tipos de dados
int number = 10;
string name =  "Guilherme de Oliveira Padilha";
double quantity = 0.0;
bool hasMoney = true;
char letter = 'A';

/* Constantes */
const int DAYS_YN_WEEK = 7;

letter = 'B';

Console.WriteLine("Informe seu nome:");
name = "Console.ReadLine()";

Console.Write("Seja bem-vindo " + name);

/* Enumeradores */

/*  enum Language {PT, EN, ES}*/

/* Contatenando strings */

string firstName = "Guilherme", lastName = "";
lastName ="Oliveira";

string fullName = firstName + "" + lastName;
Console.WriteLine (fullName);

string middleName = "Padilha";

// Interpolção de string
string message = $"Nome completo: {firstName} {middleName} {lastName}";
Console.WriteLine (message);


/* Vetores
Vetores UNI-DIMENSIONAIS
Sintaxe: type[]
*/

//Declaração sem inicialização
//Obs: Variável alocada mas nula

int[] numbers;

//inicializando o vetor
numbers = new int[5];

// Atribuindo calores ao vetor
number[0] = 10;
number[1] = 20;
number[2] = 30;
number[3] = 40;
number[4] = 50;

//É possivel declarar o vetor e já definir e atribuir

int[]  number2 =
            new int[] {100, 200, 300};
    
int[] number3 =
             {1000, 2000, 3000,4000};
// Percorrendo um vetor e adicionando valores dinamicamente

Console.WriteLine("Iniciando com vetores"
);

Console.WriteLine("Informe o tamanho do vetor de números de inteiros: ")
int size =  Convert.ToInt32 (
    Console.ReadLine()
    );

int[] myArray = new int[size];
int total = 0; //Acumuladora
int counter = 0;
                    //flag
for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(
        "Digite para [" +i+ "]: "
    );
    myArray[i] = Convert.ToInt32(
        Console.ReadLine()
    );

    total += myArray[i];
    couter++;

}
Console.WriteLine(
        "Contagem = "+ counter
        );




