static class keyboardHandler
{
  /// <summary>
  /// This method is used to handle the keyboard. This method is called in the main method. It will loop forever, and will handle the keyboards.
  /// Does the following:
  /// <list type="bullet">
  ///   <item>Get the list of keyboards present on the computer</item>
  ///   <item>For each keyboard, check if we have a configuration for it, if we do, we :</item>
  ///   <list type="bullet">
  ///     <item>If the layout is not the one we want, switch to the one we want</item>
  ///     <item>If the layout is the one we want, do nothing</item>
  ///   </list>
  ///   <item>If we don't have a configuration for the keyboard, we do nothing</item>
  ///   <item>If we didn't find a configuration for a keyboard, we reset the layout to the previous one</item>
  /// </list>
  /// </summary>
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