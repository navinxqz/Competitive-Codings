class Program{
    public static void Main(String[] args){
    var p = Console.ReadLine();
    var num = p.Split().Select(int.Parse).ToList();
    //splited the input into parts & turn them into int

    if(num.Count(x => x==5) == 2 && num.Count(x => x==7) == 1){
        //checking if list contains 2 '5' & 1 '7'
        Console.WriteLine("YES");
    }else{
        Console.WriteLine("NO");
    }
    }
}