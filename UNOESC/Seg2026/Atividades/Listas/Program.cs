//ArrayLists

ArrayList arrayList = new ArrayList();

//add itens na lista
arrayList.Add("5");

// Adicionando quantias de intens á lista
arrayList.AddRange(new int[] {1,2,3,});

//
arrayList.Insert(3, 7.8);

//percorrer a lista de forma generica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}