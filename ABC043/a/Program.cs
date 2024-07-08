class Program{
    public static void Main(string[] args){
        Console.Write("N: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int t=0;

        for(int i=0; i<=c;i++){
            t = t+i;
        }Console.Write($"{t} candies to the child!");
    }
}