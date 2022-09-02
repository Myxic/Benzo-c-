namespace question_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // last leap yr was 2020
            int count = 0;
            int leap_year = 2020;

            while (count < 20){
                //since leap years are always after 4yrs or can be divided by 4
                leap_year = leap_year + 4;

                Console.WriteLine(leap_year);
                count ++ ;
            }
        }
    }
}