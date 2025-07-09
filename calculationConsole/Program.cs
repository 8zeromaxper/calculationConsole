class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Soo dhawow Sheik. Mohamed Ahmed !");
            Console.WriteLine(" ... Tani waa xisaabinta ugu fudud ee C# ...");
            Console.WriteLine("1. Ku-dar");
            Console.WriteLine("2. Ka-jar");
            Console.WriteLine("3. Ku-dhufo");
            Console.WriteLine("4. U-qaybi");
            Console.WriteLine("5. Ka bax");
            Console.Write("Fadlan kuwaan mid un ka dooro (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Waad iska xirtay isagoo dhan. nagukalawad!");
                break;
            }

            Console.Write("Fadlan gali L.1aad: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Fadlan gali L.2aad: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validChoice = true;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine("Jawaabtu waa : " + result);
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine("Jawaabtu waa : " + result);
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine("Jawaabtu waa : " + result);
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Jawaabtu waa : " + result);
                    }
                    else
                    {
                        Console.WriteLine("Qallad : Uqaybida lama ogola Eber !.");
                    }
                    break;
                default:
                    validChoice = false;
                    Console.WriteLine("Lambar khaldan. Fadlan ka dooro 1 ilaa 5.");
                    break;
            }

            if (validChoice)
            {
                Console.WriteLine("Meel un taabo si uu kuugu sii socdo...");
                Console.ReadKey();
            }
        }
    }
}
