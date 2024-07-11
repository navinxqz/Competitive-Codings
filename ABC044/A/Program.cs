class Hotel{
    public int n{get;set;}
    public int k{get;set;}
    public int x{get;set;}
    public int y{get;set;}

    public Hotel(int n,int k,int x,int y){
        this.n = n; this.k = k;
        this.x = x; this.y = y;
    }
    public int totalFee(){
        if(n <=k){
            return n*x;
        }else{
            int init = k*x;
            int seq = (n-k)*y;
            return seq+init;
        }
    }
}
class Program{
    public static void Main(string[] args){
        Console.Write("Night staying N = ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("night K = ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{k} night fee X = ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write($"({k}+1) & subsequent night fee Y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Hotel tak = new Hotel(n,k,x,y);
        System.Console.WriteLine($"Fee: {tak.totalFee()}");
    }
}