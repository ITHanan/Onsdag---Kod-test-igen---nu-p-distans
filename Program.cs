namespace Onsdag___Kod_test_igen___nu_på_distans
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
            Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1


            static int MestFrekventSiffra(int[] number)
            {

                if (number.Length == 0)
                {
                    Console.WriteLine("Output: 0 (Arrayen är tom)");
                    return 0;
                }


                int mostFrequent = number[0];
                int maxcount = 0;


                for (int i = 0; i < number.Length; i++)
                {
                    int count = 0; 

                    for (int j = 0; j < number.Length; j++)
                    {
                        if (number[i] == number[j])// if it true that means that we have a dublicated number 
                        {
                            count++;
                        }

                    }

                    if (count > maxcount || (count == maxcount && number[i] < mostFrequent)) 
                    {

                        maxcount = count;
                        mostFrequent = number[i];

                       

                    }

                   
                }


                Console.WriteLine($"Input: [{string.Join(", ", number)}]");
                Console.WriteLine($"{mostFrequent} number {mostFrequent} occurs {maxcount} timse, which is the most");
                return mostFrequent;
            }
            
          

        }
    }
}
