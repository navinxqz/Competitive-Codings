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
    public static void Main(string[] args){}
}