using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


// ========================================
// ARRAYLIST
// ========================================

// Criando a lista
ArrayList arrayList = new ArrayList();

// Adicionando itens na lista
arrayList.Add("5");

// Adicionando múltiplos itens
arrayList.AddRange(new int[] { 1, 2, 3 });

// Inserindo o valor 7.8 no índice 3
arrayList.Insert(3, 7.8);

// Percorrendo a lista
Console.WriteLine("=== ARRAYLIST ===");

foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}


// ========================================
// LISTAS GENÉRICAS
// ========================================

List<double> numbers = new List<double>();

Console.WriteLine();
Console.WriteLine("=== LISTA DE NÚMEROS ===");
Console.WriteLine("Digite 'sair' para encerrar.");

bool run = true;

do
{
    Console.WriteLine("Digite um número:");

    string numberStr = Console.ReadLine();

    if (numberStr.ToLower() == "sair")
    {
        run = false;
    }
    else
    {
        // Validação para garantir que o usuário digite um número válido
        if (!double.TryParse(
            numberStr,
            NumberStyles.Float,
            new NumberFormatInfo(),
            out double number))
        {
            Console.WriteLine("Você não digitou um número válido.");
            continue;
        }

        // Adicionando o número na lista
        numbers.Add(number);

        // Calculando a média
        Console.WriteLine(
            "A média dos valores informados é: "
            + numbers.Average()
        );
    }

} while (run);


// 
// LISTA DE PERSON
// 

Console.WriteLine();
Console.WriteLine("=== LISTA DE PESSOAS ===");

// Criando a lista de pessoas
List<Person> people = new List<Person>();


// Criando e adicionando p1
Person p1 = new Person();

p1.Name = "Guilherme de Oliveira";
p1.Age = 18;
p1.Nationality = CountryEnum.BR;

people.Add(p1);


// Adicionando uma pessoa diretamente na lista
people.Add(new Person()
{
    Name = "Padilha",
    Age = 30,
    Nationality = CountryEnum.US
});


// Adicionando outra pessoa
people.Add(new Person()
{
    Name = "GOP",
    Age = 39,
    Nationality = CountryEnum.AR
});


// 
// ORDENAÇÃO DA LISTA
// 

// Ordenando a lista de pessoas pelo nome
List<Person> result =
    people
        .OrderBy(p => p.Name)
        .ToList();


// 
// PERCORRENDO A LISTA
// 

Console.WriteLine();
Console.WriteLine("=== PESSOAS ORDENADAS POR NOME ===");

foreach (Person p in result)
{
    Console.WriteLine(
        $"Nome: {p.Name}, " +
        $"Idade: {p.Age}, " +
        $"Nacionalidade: {p.Nationality}"
    );
}