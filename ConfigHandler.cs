using System.Text.Json;

static class ConfigHandler
{
  static List<KeyboardLayoutConfig> _keyboardLayoutConfigs = new();
  const string configFileName = "config.json";

  /// <summary>
  /// This method is used to load the config file.
  /// </summary>
  /// <returns>True if the config file was loaded, false otherwise</returns>
  public static bool LoadConfig()
  {
    if (!File.Exists(configFileName))
      return false;

    string config = File.ReadAllText(configFileName);
    if (config != null)
    {
      var keyboardLayoutConfigs = JsonSerializer.Deserialize<List<KeyboardLayoutConfig>>(config);
      if (keyboardLayoutConfigs != null)
      {
        _keyboardLayoutConfigs = keyboardLayoutConfigs;
        return true;
      }
    }
    return false;
  }

  /// <summary>
  /// This method is used to generation the configuration for the keyboards.
  /// </summary>
  /// <param name="keyboards">The list of keyboards present on the computer</param>
  public static void CreateConfig(List<KeyboardInfo> keyboardsInfo)
  {
    foreach (var keyboardInfo in keyboardsInfo)
    {
      var keyboardCode = KeyboardLayout.GetLayoutCode();
      _keyboardLayoutConfigs.Add(new KeyboardLayoutConfig()
      {
        Layout = keyboardCode, // Set current layout as default
        DeviceID = keyboardInfo.DeviceID,
        PostMessage = $"Switching to {KeyboardLayoutConverter.CodeToName(keyboardCode)}"
      });
    }

    string config = JsonSerializer.Serialize(_keyboardLayoutConfigs);
    File.WriteAllText(configFileName, config);
  }

  /// <summary>
  /// This method is used to get the configuration for a keyboard, based on its DeviceID.
  /// </summary>
  /// <param name="deviceID">The DeviceID of the keyboard</param>
  /// <returns>The configuration for the keyboard, or null if no configuration was found</returns>
  public static KeyboardLayoutConfig? GetConfig(string deviceID)
  {
    return _keyboardLayoutConfigs.Where(x => x.DeviceID == deviceID).FirstOrDefault();
  }
}