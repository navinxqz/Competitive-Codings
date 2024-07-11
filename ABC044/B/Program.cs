class Program{
    public static bool IsBeautiful(string s){
        if(s==null){return true;}
    }
    //var counter = new Dictionary<char, int>();
    int[] counter = new int[26];    //for 26 letters
    foreach (char c in s)
    {
        counter[c - 'a']++;
    }foreach(int count in counter){
        bool check = (count%2 !=0) ? false : true;
    }

    public static void Main(string[] args){
        System.Console.Write("Input String: ");
        string input = Console.ReadLine();

        Console.WriteLine("String beautiful? : {0}",check);
    }
}