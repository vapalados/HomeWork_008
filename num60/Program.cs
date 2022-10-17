//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] Vvod_massiva()
{
    int[,,] Massiv = new int[2,2,2];
    Random rnd = new Random();
    for (int x = 0; x<2; x++)
    {
        for (int y = 0; y<2; y++)
        {
            for (int z = 0; z<2; z++)
            {    
            Massiv[x,y,z]=NotRandom(Massiv, rnd.Next(10,99));
            }
        }
    }
    return Massiv;
}
int NotRandom(int[,,] mas, int a)
{
    Random rnd = new Random();
    for (int x = 0; x<2; x++)
    {
        for (int y = 0; y<2; y++)
        {
            for (int z = 0; z<2; z++)
            {    
                if (a == mas[x,y,z])
                {
                    a = NotRandom(mas, rnd.Next(10,99));
                }
            }
        }
    }
    return a;
}
void Vivod_Massiva(int[,,] mass)
{
    for (int x = 0; x<2; x++)
    {
        for (int y = 0; y<2; y++)
        {
            for (int z = 0; z<2; z++)
            {   
                Console.Write(mass[x,y,z] + " (" + x + "," + y + "," + z + ") ");
            }
            Console.WriteLine("");
        }
    }
}
Console.WriteLine("Итоговый Массив: ");
Vivod_Massiva(Vvod_massiva());