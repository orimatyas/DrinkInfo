namespace DrinkInfo
{
    internal class Controler
    {
        internal static void DrinkPage()
        {
            UserInput userInput = new();
            userInput.GetCategoriesInput();
        }

        internal static void Favourites()
        {
            throw new NotImplementedException();
        }

        internal static void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
