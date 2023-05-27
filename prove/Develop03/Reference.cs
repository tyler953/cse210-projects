namespace Develop03
{
    public class Reference
    {
        private string reference;

        public string GetReference()
        {
            return reference;
        }

        public void StoreReference(string scripture)
        {
            string[] splitScripture = scripture.Split(" | ");
            reference = splitScripture[0];
        }
    }
}