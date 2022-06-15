void Distance3D (int Ax, int Ay, int Az, int Bx, int By, int Bz )
{
    double AB = Math.Sqrt(Math.Pow((Bx-Ax), 2)+Math.Pow((By-Ay), 2)+Math.Pow((Bz-Az), 2));
    System.Console.WriteLine(AB);
}
Distance3D(2,3,4,5,6,7);
Distance3D(2,-3,4,5,-6,7);
Distance3D(2,23,4,5,57,7);

