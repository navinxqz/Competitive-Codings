//using System.Collections.Generic;
class Program{
    static long Temp(string s){ //used long to store large value that int can't handle
    //to sum the part separated by +
        long output = 0;
        //long temp = 0;

        string[] part = s.Split('+');
        foreach(string e2 in part){
            output += long.Parse(e2);
        }return output;
    }
    static int Combination(int n){  //recursive method
        if(n==0){ return 1;}
        return 2*Combination(n-1);
    }
    static string[] forms(string s){    //all the possible formula & insert +
        int combination = Combination(s.Length-1);
        string[] result = new string[combination];

        for(int i = 0; i<combination; i++){
            string pattern = "";
            int div=1;
            for(int j=0;j<s.Length;j++){
                pattern += s[j];

                if(j<s.Length-1 && (i/div)%2 == 1){
                    pattern += "+";
                }div *=2;
            }result[i] = pattern;
        }return result;
    }
    static long Formulas(string s){  //for making all th possible formulas
        long sum = 0;
        string[] p = forms(s);

        foreach(var item in p){
            sum += Temp(item);
        }return sum;
    }
    
    public static void Main(string[] args){
        string s = Console.ReadLine();
        Console.WriteLine(Formulas(s));
    }
}