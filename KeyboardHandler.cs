static class keyboardHandler
{
  public static void HandleKeyboard()
  {
    LayoutChanges layoutChanges = new LayoutChanges();

    while (true)
    {
      layoutChanges.changedDuringCurrentIteration = false;

      var keyboards = KeyboardInfoFetcher.GetKeyboardPresent();
      foreach (var keyboard in keyboards)
      {
        if (keyboard.DeviceID == null)
          continue;

        var config = ConfigHandler.GetConfig(keyboard.DeviceID);
        if (config != null)
        {
          if (config.Layout == layoutChanges.layout)
          {
            layoutChanges.changedDuringCurrentIteration = true;
            break;
          }
          layoutChanges.Changing(KeyboardLayout.GetLayoutCode(), config.Layout);

          KeyboardLayout.SwitchToLanguage(KeyboardLayoutConverter.NameToCode(config.Layout));
          Console.WriteLine(config.PostMessage);
          break;
        }
      }

      if (layoutChanges.ShouldReset())
        layoutChanges.Reset();

      System.Threading.Thread.Sleep(5000);
    }
  }
}