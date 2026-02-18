int n = int.Parse(Console.ReadLine());
string racingNum = Console.ReadLine();
char[,] route = new char[n, n];

for (int i = 0; i < n; i++)
{
    char[] currentRow = Console.ReadLine().Replace(" ", "").ToCharArray();

    for (int j = 0; j < n; j++)
    {
        route[i, j] = currentRow[j];
    }
}

int currRow = 0;
int currCol = 0;
int distance = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        Console.WriteLine($"Racing car {racingNum} DNF.");
        break;
    }

    if (command == "up") currRow--;
    else if (command == "down") currRow++;
    else if (command == "left") currCol--;
    else if (command == "right") currCol++;

    char position = route[currRow, currCol];

    if (position == '.')
    {
        distance += 10;
    }
    else if (position == 'T')
    {
        distance += 30;
        route[currRow, currCol] = '.'; 

        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (route[r, c] == 'T')
                {
                    currRow = r;
                    currCol = c;
                    route[r, c] = '.';
                    break;
                }
            }
        }
    }
    else if (position == 'F')
    {
        distance += 10;
        Console.WriteLine($"Racing car {racingNum} finished the stage!");
        break;
    }
}

route[currRow, currCol] = 'C';
Console.WriteLine($"Distance covered {distance} km.");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(route[i, j]);
    }
    Console.WriteLine();
}