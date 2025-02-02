namespace Assignment_Session_4_Advanced_C_
{
    internal class Program
    {
        static void ReverseList<T>(List<T> list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        static HashSet<int> GetEvenNumbers(HashSet<int> numbers)
        {
            HashSet<int> evenNumbers = new HashSet<int>();

            foreach (int num in numbers)

                if (num % 2 == 0)
                    evenNumbers.Add(num); 

            return evenNumbers;
        }

        static int FirstNonRepeatedCharacter(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            for (int i = 0; i < s.Length; i++)
                if (charCount[s[i]] == 1)
                    return i; 
            return -1; 
        }


        static void Main(string[] args)
        {
            #region Q 1

            //List<int> myList = new List<int> { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"Original List: {string.Join(", ", myList)}");

            //Console.WriteLine("=============================================");

            //ReverseList(myList);

            //Console.WriteLine($"Reversed List: {string.Join(", ", myList)}"); 
            #endregion

            #region Q 2

            //HashSet<int> Numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 12, 13, 18, 22 };

            //Console.WriteLine($"Original HashSet: {string.Join(", ", Numbers)}");

            //Console.WriteLine("=============================");

            //HashSet<int> evenNumbers = GetEvenNumbers(Numbers);

            //Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");
            #endregion

            #region Q 3

            //FixedList<int> list = new FixedList<int>(5);

            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            //list.Add(50);

            //try
            //{

            //    list.Add(40);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //try
            //{
            //    Console.WriteLine(list.Get(6)); 
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Q 4

            //string input = "MMostafa";

            //int result = FirstNonRepeatedCharacter(input);

            //if (result != -1)
            //    Console.WriteLine($"First non-repeated character is at index: {result}");
            #endregion

        }
    }
}
