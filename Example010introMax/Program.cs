int a1 = 8;
int b1 = 15;
int c1 = 45;
int a2 = 64;
int b2 = 1162;
int c2 = 33;
int a3 = 103;
int b3 = 145;
int c3 = 589;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3, b3, c3));
Console.WriteLine(max);
