using System.Text.Json;

static class ConfigHandler
{
  static List<KeyboardLayoutConfig> _keyboardLayoutConfigs = new();
  const string configFileName = "config.json";

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

  public static KeyboardLayoutConfig? GetConfig(string deviceID)
  {
    return _keyboardLayoutConfigs.Where(x => x.DeviceID == deviceID).FirstOrDefault();
  }
}