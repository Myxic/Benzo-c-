namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word or sentence");
            var words = Console.ReadLine();

            //make all the letters lowercase
            words = words.ToLower();

            string output;
            output = "";

            foreach (var word in words.Split(" "))
            {
                // removing the first letter and moving it behind before adding ay
                var use = word.Remove(0, 1);
                var result = use + word[0] + "ay";

                // joining the strings together
                output += result + " ";
            };
           // making the first letter uppercase
            string last_output = output[0].ToString().ToUpper() + output.Remove(0,1);
        Console.WriteLine(last_output);

        }
    }
}