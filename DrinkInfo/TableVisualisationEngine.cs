using ConsoleTableExt;
using DrinkInfo.Models;
using Spectre.Console;
using System.Diagnostics.CodeAnalysis;

namespace DrinkInfo
{
    internal class TableVisualisationEngine
    {
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T :
        class
        {
            Console.Clear();
            if (tableName == null)
                tableName = "";
            Console.WriteLine("\n\n");
            ConsoleTableBuilder
                .From(tableData)
                .WithColumn(tableName)
                .ExportAndWriteLine(TableAligntment.Center);
            Console.WriteLine("\n\n");
        }

        internal static void ShowMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                var option = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuOptions>()
                    .Title(@"---DrinksInfo---
Main Menu:")
                    .AddChoices(
                        MenuOptions.DrinkPage,
                        MenuOptions.Favourites,
                        MenuOptions.Quit));
                switch (option)
                {
                    case MenuOptions.DrinkPage:
                        Controler.DrinkPage();
                        break;
                    case MenuOptions.Favourites:
                        Controler.Favourites();
                        break;
                    case MenuOptions.Quit:
                        Controler.Quit();
                        break;
                }
            }
        }
    }
}
