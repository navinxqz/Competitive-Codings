using System.Collections.Generic;
class Program{
    static long Temp(string s){ //used long to store large value that int can't handle
        long output = 0;
        //long temp = 0;

        string[] part = s.Split('+');
        foreach(string e2 in part){
            //temp = temp*10 + int.Parse(e2);
            output += long.Parse(e2);
        }return output;
    }
    static long Formulas(string s){  //for making all th possible formulas
        long sum = 0;
        
        /*for(int i = 0;i<s.Length;i++){
            for(int j = i+1;j<s.Length;j++){
                string substring = s.Substring(i,j-i);
                sum += Temp(substring);
            }
        }   */
        return sum;
    }
    static string[] forms(string s){
        int combination = 1 << (s.Length-1);
        string[] result = new string[combination];
        for(int i = 0;i<combination;i++){
            string pattern = "";
            for(int j=0;j<s.Length;j++){
                pattern += s[j];

                if(j<s.Length-1 && ((i >> j)& 1)== 1){ pattern += "+"; }
            }result[i] = pattern;
        }return result;
    }
    public static void Main(string[] args){
        long s = Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine(s);
    }
}