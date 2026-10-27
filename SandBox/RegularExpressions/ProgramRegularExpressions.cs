using System.Text.RegularExpressions;

namespace SandBox.RegularExpressions
{
    internal class ProgramRegularExpressions
    {
        public static void RunMain()
        {

            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine(matchCollection.Count);
            Console.WriteLine("===");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.WriteLine("Run Main");
        }
    }
}
