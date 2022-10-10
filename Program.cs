
class ShimiKeyboard
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Running...");

    // If config file exists, load it
    if (ConfigHandler.LoadConfig())
    {
      ConsoleUtils.HideConsole();

      keyboardHandler.HandleKeyboard();
    }
    else // Creating the config file, with the current keyboard layout
    {
      var keyboards = KeyboardInfoFetcher.GetKeyboardPresent();
      ConfigHandler.CreateConfig(keyboards);
      Console.WriteLine("Config created, modify it to fit your needs and run the program again");
      Console.WriteLine("Press any key to exit....");
      Console.ReadLine();
    }

  }
}