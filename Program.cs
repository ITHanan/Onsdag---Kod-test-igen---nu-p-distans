namespace Onsdag___Kod_test_igen___nu_på_distans
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
            Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1



        }



        public static int MestFrekventSiffra(int[] number)
        {

            if (number.Length == 0)
            {
                Console.WriteLine("Output: 0 (Arrayen är tom)");
                return 0;
            }
              

            Dictionary<int, int> frequency = new Dictionary<int, int>();


            foreach (int num in number) 
            {

                if (frequency.ContainsKey(num))
                { 
                frequency[num]++;


                }
                else{
                
                 frequency[num] = 1;
               
                }
            
            
            }
            int mostFrequent = number[0];
            int maxcount = 0;



          foreach (var highestnum in frequency)
            { 

                if (highestnum.Value > maxcount || (highestnum.Value == maxcount && highestnum.Key < mostFrequent))
                {
                    mostFrequent = highestnum.Key;
                    maxcount = highestnum.Value;
                }

            }
            Console.WriteLine($"Input: [{string.Join(", ", number)}]");
            Console.WriteLine($" number {mostFrequent} occurs {maxcount} timse  , which is the most");
            return mostFrequent;

        }



    }

}
