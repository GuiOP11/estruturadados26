using System.Collections;
using System.Globalization;


// Criando a lista
ArrayList arrayList = new ArrayList();

// Adicionando itens na lista
arrayList.Add("5");

// Adicionando múltiplos itens (Correção: removida a vírgula sobressalente após o 3)
arrayList.AddRange(new int[] { 1, 2, 3 });

// Inserindo o valor 7.8 no índice 3
arrayList.Insert(3, 7.8);

// Percorrendo a lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}


// listas genericas

List<double> numbers  = new List<double>();
Console.WriteLine("Digite 'Sair' para encerrar.");

bool run = true;
do
{
    Console.WriteLine("Digite um número:");
    string numberStr = Console.ReadLine();

    if(numberStr.Equals("sair"))
    {
        run = false;
        
    }
    else
    {
        // Validação para garantir que o usuário digite um número válido
        if(!double.TryParse(numberStr, System.Globalization.NumberStyles.Float,
         new NumberFormatInfo(),
        out double number
        )
        ){
            Console.WriteLine("Você não digitou um número válido.");
            continue;


    }
        numbers.Add(number);
        Console.WriteLine(
            "A média dos valores informados é: "
             + numbers.Average()
             );
             

    }
    
}while (run);
