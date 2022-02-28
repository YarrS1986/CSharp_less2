// Нахождение максимума из 9 переменных

int Max(int arg1, int arg2, int arg3)       // функция
{
    int rezult = arg1;
    if (arg2 > rezult) rezult = arg2;
    if (arg3 > rezult) rezult = arg3;
    return rezult;
} //        инд  0   1   2   3   4   5   6   7   8
int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);