// See https://aka.ms/new-console-template for more information
class Program
{
    public static int squares(int a, int b) {
        int count = 0;
        for (int i = 0; i*i <= b; i++) {
            if (i * i <= b && i * i >= a) {
                count++;
            }
        }
        return count;
    }
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = squares(a, b);
        Console.WriteLine(result);
    }
}
