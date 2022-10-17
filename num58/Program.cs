//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
double[,] Vvod_massiva()
{
    double[,] Massiv = new double[2,2];
    Random rnd = new Random();
    for (int i = 0; i<2; i++)
    {
        for (int j = 0; j<2; j++)
        {
            Massiv[i,j]=rnd.Next(0,10);
        }
    }
    return Massiv;
}
void Vivod_Massiva(double[,] mass)
{
    for (int i = 0; i<2; i++)
    {
        for (int j = 0; j<2; j++)
        {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine(" ");
    }
}
double[,] Proizvedenie(double[,] mass, double[,] mass2)
{
    double[,] mass3 = new double[2,2];
        for (var i = 0; i < 2; i++)
        {
            for (var j = 0; j < 2; j++)
            {
                mass3[i, j] = 0;
                for (var k = 0; k < 2; k++)
                {
                    mass3[i, j] += mass[i, k] * mass2[k, j];
                }
            }
        }
    return mass3;
}
double [,] mas = Vvod_massiva();
double [,] mas2 = Vvod_massiva();
Console.WriteLine("Матрица А: ");
Vivod_Massiva(mas);
Console.WriteLine("Матрица B: ");
Vivod_Massiva(mas2);
double [,] mas3 = Proizvedenie(mas,mas2);
Console.WriteLine("Матрица C: ");
Vivod_Massiva(mas3);