class LargestNumber
{
    static void Main()
    {
        //hardcoded 3 numbers
        int num1 = 60;
        int num2 = 45;
        int num3 = 123;

        // declare variables
        int large = 0;

        //Check if Number 1 is larger the other 2
        if(num1 > num2 && num1 > num3)
        {
           large = num1;
        }
        //Check if Number 2 is larger the other 2
        else if (num2 > num3&& num2 > num1)
        {
            large = num2;
        }
        //Check if Number 3 is larger the other 2
        else
        {
            large = num3;
        }
        System.Console.WriteLine(large);
        System.Console.ReadKey();
    }
}