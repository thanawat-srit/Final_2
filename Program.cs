class Program
{
    static Stack<string> stack = new Stack<string>();
    static void Main(string[] args)
    {
        int start=0;
       
        Input();
        if (check(ref start) == 0)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
    static void Input()
    {
        int side=0;
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if(side==0){
                if (input == "(")
                {
                    stack.Push(input);
                    side++;
                }
                else if(input == ")")
                {
                    Console.Clear();
                    Console.WriteLine("Plaese try again");
                }else{
                    break;
                }
            }else{
                if (input == "("||input == ")")
                {
                    stack.Push(input);
                }else{
                    break;
                }
            }
        }
    }

    static int check(ref int count)
    {
        for (int i = 0; i < stack.GetLength(); i++)
        {
            string p = stack.Pop();
            if (p == ")")
            {
                count++;
                check(ref count);
            }
            else if (p == "(")
            {
                count--;
                check(ref count);
            }
        }
        return count;
    }
}