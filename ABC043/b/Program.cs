class Program{
    public static string Key(string key){
        string String = "";

        foreach(char c in key){
            switch(c){
                case '0': String += c; break;
                case '1': String += c; break;
                case 'B': if(String.Length > 0){ //for backspace key
                    String = String.Substring(0, String.Length-1);
                }break;
                default: Console.WriteLine("[s consists of 0, 1 & B!]"); break;
            }
            /*  if(c == '0' || c=='1'){ String += c; }
                else if(c=='B'){
                    if(String.Length > 0){ //for backspace key
                    String = String.Substring(0, String.Length-1);

                }}else{Console.WriteLine("[s consists of 0, 1 & B!]");}     */
        }return String;
    }
    public static void Main(string[] args){
        Console.Write("Input: ");
        string s = Console.ReadLine();
        Console.WriteLine("Output: "+ Key(s));
    }
}