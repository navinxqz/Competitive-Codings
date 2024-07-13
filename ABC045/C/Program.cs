class Program{
    static long Temp(string s){ //used long to store large value that int can't handle
        long output = 0;
        long temp = 0;

        string[] e = s.Split('+');
        foreach(string e2 in e){
            temp = temp*10 + int.Parse(e2);
        }output += temp;
        return output;
    }
    static long Calculation(string s){
        long sum = 0;
        for(int i = 0;i<s.Length;i++){
            for(int j = i+1;j<s.Length;j++){
                string substring = s.Substring(i,j-i);
                sum += Temp(substring);
            }
        }return sum;
    }
    public static void Main(string[] args){
        long s = Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine(s);
    }
}