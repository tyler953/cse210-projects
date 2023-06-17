namespace Develop04
{
    public class Menu
    {
        private int _selection;

        public void SetSelection(int selection)
        {
            this._selection = selection;
        }

        public int GetSelection()
        {
            return this._selection;
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            SetSelection(int.Parse(Console.ReadLine()));
        }
    }
}