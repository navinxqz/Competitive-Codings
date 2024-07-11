class Program{
public static void Main(string[] args){
    System.Console.Write("Upper base value: ");
    int a = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Lower base value: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Height: ");
    int h = Convert.ToInt32(Console.ReadLine());

    if(1<=a && a<=100 && 1<=b && b<=100 && 1<=h && h<=100 && (h%2==0)){ //constraints
        int area = ((a+b)*h)/2;
        Console.WriteLine("Area: "+area);
    }else{
        Console.WriteLine("Out of constraints!\n");
    }
}
}