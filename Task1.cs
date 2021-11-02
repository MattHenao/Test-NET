using System;

public class Program
{
    public static void Main()
    {
        int x = 3;
        int y = 5;
        int n = 20;
        int aux = 0;

        for(int i = 0; i <= n; i++){
            if((i % x == 0) || (i % y == 0)){
                aux += i;
            }
        }
    Console.WriteLine(aux);
    }
}