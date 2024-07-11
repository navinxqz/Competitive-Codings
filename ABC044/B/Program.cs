class Program{
    public static bool IsBeautiful(string s){
        if(s==null){return true;}

    int[] counter = new int[26];    //for 26 letters
    foreach (char c in s){
        counter[c - 'a']++;
    }bool check = true;

    foreach(int count in counter){  //check for the even num
        check = (count%2 !=0) ? false : check;
    }return check;
    }
    public static void Main(string[] args){
        Console.Write("Input String: ");
        string input = Console.ReadLine();

        Console.WriteLine("String beautiful? : {0}",IsBeautiful(input.ToLower()));
    }
}