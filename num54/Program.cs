//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
double[,] Vvod_massiva(int m,int n)
{
    double[,] Massiv = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Massiv[i,j]=rnd.Next(0,10);
        }
    }
    return Massiv;
}
void Vivod_Massiva(double[,] mass, int m, int n)
{
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine(" ");
    }
}
double[,] Sortmassiv(double[,] mass, int m, int n)
{
    double temp;
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            for (int f = 0; f < m; f++)
            {   
              if (mass[i,j] < mass[i,f])
                {
                temp = mass[i,j];
                mass[i,j] = mass[i,f];
                mass[i,f] = temp;
                }
            }
        }
    }
    return mass;
}
 Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double [,] mas = Vvod_massiva(a,b);
Vivod_Massiva(mas,a,b);
Sortmassiv(mas,a,b);
Console.WriteLine("Отсортированный массив:");
Vivod_Massiva(mas,a,b);