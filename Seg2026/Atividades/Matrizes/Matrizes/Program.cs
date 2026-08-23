// Vetor Bi-Dimensional
int[,] numbersBi = new int[5, 2];

// Vetor Tri-Dimensional
int[,,] numbersTri = new int[5, 4, 3];

// Inicialização de uma matriz 5x3
int[,] newNumbersBi = new int[,] {
    { 9, 5, -9 },
    { -11, 4, 0 },
    { 6, 115, 3 },
    { -12, -9, 71 },
    { 1, -6, -1 }
};

// Percorrendo a matriz
for (int i = 0; i < newNumbersBi.GetLength(0); i++)
{
    for (int j = 0; j < newNumbersBi.GetLength(1); j++)
    {
        Console.Write($"[{newNumbersBi[i, j]}]");
    }

    Console.WriteLine("");
}



//atribuindo

int[][] jaggedNumbers2 =
{
    new int[] { 9, 5, 2 },
    new int[] { 1, 2, 3, 4 },
    new int[] { 5, 6 },
    new int[] { 7, 8, 9, 10 }
};

// Acessando uma posição
int n = jaggedNumbers2[1][2];

jaggedNumbers2[1][2] = 22;

Console.WriteLine("n = " + n);

Console.WriteLine(
    "jaggedNumbers2[1][2] = " + jaggedNumbers2[1][2]
);
