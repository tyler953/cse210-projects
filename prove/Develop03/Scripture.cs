namespace Develop03
{
    public class Scripture
    {
        private string scripture;

        public string GetScripture()
        {
            return scripture;
        }

        public void ChooseNewScripture()
        {
            var scriptures = File.ReadAllLines("scriptures.txt");
            var random = new Random();
            var randomScripture = random.Next(0, scriptures.Length - 1);
            scripture = scriptures[randomScripture];
        }
    }
}