Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int []array = new int [N];

int index = 0;
int num = 0;

while (index < N)
{
    array[index] = num * num * num;
    Console.Write(array[index] + " ");
    num ++;
    index ++;
}
