using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PredygerKK.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            var l = new List<string>();
            string[] words = value.Split(" ");
            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    l.Add(word);
                }
                else
                {
                    l.Add(word.Remove(word.Length / 2, 1));
                }
            }
            return string.Join(" ", l);
        }
    }
}
