namespace lesson9_12;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public static void hello(){
        Console.WriteLine("Введите свое имя ");
        string? a = Console.ReadLine();
        Console.WriteLine("Привет," + a + "!");
    }

    public static int max_num(int a, int b){
        if (a > b){
            return a;
        }
        else{
            return b;
        }
    }

    public static bool test_chetnost(int a){
        return a % 2 == 0;
    }

    public static void convert_temperature(int a){
        double b = (a * 1.8) + 32;
        Console.WriteLine(b);
    }

    public static string revers_string(string str){
        char[] new_str = str.ToCharArray(); 
        Array.Reverse(new_str);
        return new String(new_str);
    }

    public static void count_sumb(string a, string b){
        int cnt = 0;
        for (int i = 0; i < a.Length; i++){
            if (a[i].ToString() == b){
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }

    public static void factorial(int a){
        int b = 1;
        for (int i = 0; i < a; i++){
            b *= (a - i);
        }
        Console.WriteLine(b);
    }

    public static bool check_simple_num(int a){
        if (a < 2){
            return true;
        }
        for (int i = 2; i < Math.Sqrt(a); i++){
            if (a % i == 0){
                return false;
            }
        }
        return true;
    }
}
