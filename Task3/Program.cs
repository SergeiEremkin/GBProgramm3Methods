void CubeNumber(int N)
{
    for(double i = 1; i<=N; i++)
    {
        double cube = Math.Pow(i,3);
        System.Console.Write($"{cube}  ");
    }
}
CubeNumber(3);
System.Console.WriteLine();
CubeNumber(25);
System.Console.WriteLine();
CubeNumber(10);