using System.Text;

namespace text_formatter
{
    internal class Program
    {
        /// <summary>
        /// this program removes new lines and gets rid of headers from the text inputted
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("paste text here, type end when finished:");
            string temp = Console.ReadLine();
            while (temp != "end")
            {
                sb.Append(temp.Replace("\n", " "));
                temp = Console.ReadLine();
            }
            
            Console.WriteLine(sb.ToString());
     

        }
    }
}