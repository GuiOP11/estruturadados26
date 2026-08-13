/*Crie um Programa que seja capaz de ler 10 números interros e separá-los em 2 vetores, 1 para os ímpares e outro para os pares.
Ao final, imprima na tela os pares e depois os ímpares.
*/

Console.WriteLine("Programa para separar números pares e ímpares.");
Console.WriteLine("Digite 10 números para ver se é par ou ímpar: ");



int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];


int par = 0;
int impar = 0;


for( int i = 0; i < 10; i++)

{
 
 
   Console.WriteLine(
        "Digite o número [" +  i + "]: "
    );

    myArray[i] = Convert.ToInt32(
        Console.ReadLine()
    );


    if (myArray[i] % 2 == 0)
 {
    pares [par] = myArray[i];
    par++;
 }
 else
 {
    impares [impar] = myArray[i];
    impar++;
 }

    
    
   

}


for (int i = 0; i < par; i++)
{
    Console.Write("Numero pares "+pares[i] + " ");
    Console.WriteLine("Numeros impares "+impares[i] + " ");

}


   