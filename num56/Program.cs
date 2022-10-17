//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void BigSum(double[,] mass, int m, int n)
{
    double tempsum = 100;
    double tempsumnew = 0;
    int nomerstroki = 0;
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            tempsumnew = tempsumnew + mass[i,j];
        }
        if (tempsum > tempsumnew)
        {
            tempsum = tempsumnew;
            nomerstroki = i; 
        }
        tempsumnew = 0;
    }
    nomerstroki++;
    Console.WriteLine("Сумма чисел в строке " + nomerstroki + " наименьшая.");
}
 Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double [,] mas = Vvod_massiva(a,b);
Vivod_Massiva(mas,a,b);
BigSum(mas,a,b);