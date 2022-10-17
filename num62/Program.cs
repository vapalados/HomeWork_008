//Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] Vvod_massiva()
{
    int[,] mass = new int[4, 4];
            int line = 0, stolb = 0, dx = 1, dy = 0, change = 0, povtor = 4;
 
            for (int i = 0; i < 16; i++)
            {
                mass[line, stolb] = i + 1;
                if (--povtor == 0)
                {
                    povtor = 4*(change%2) + 4*((change + 1)%2) - (change/2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    change++;
                }
                stolb += dx;
                line += dy;
            }
            return mass;
}
void Vivod_Massiva(int[,] mass)
{
    for (int i = 0; i<4; i++)
    {
        for (int j = 0; j<4; j++)
        {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine(" ");
    }
}
int [,] mas = Vvod_massiva();
Vivod_Massiva(mas);