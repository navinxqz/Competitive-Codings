using System.Linq;
class Program{
    public static void Main(string[] args){
    /*    string[] s = Console.ReadLine().Split(' '); //split the input into ary
        int a = int.Parse(s[0]);    //parse string to int
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        int[] color = {a,b,c};
        Console.WriteLine(color.Distinct().Count());    */
        Console.WriteLine(Console.ReadLine().Split(' ').Distinct().Count());
    }
}