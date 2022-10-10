using System.Management;

class KeyboardInfoFetcher
{
  private const string USB = "USB";

  /// <summary>
  /// This method is used to get the list of keyboards present on the computer.
  /// </summary>
  /// <returns>A list of keyboards present on the computer</returns>
  public static List<KeyboardInfo> GetKeyboardPresent()
  {
    List<KeyboardInfo> keyboards = new();
#pragma warning disable CA1416 // This is a Windows only application, so we can use WMI
    ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_Keyboard");

    foreach (ManagementObject keyboard in searcher.Get())
    {
      var description = keyboard.Properties["Description"].Value.ToString();
      if (description != null && description.Contains(USB))
      {
        keyboards.Add(new KeyboardInfo()
        {
          Caption = keyboard.Properties["Caption"].Value.ToString(),
          Description = keyboard.Properties["Description"].Value.ToString(),
          DeviceID = keyboard.Properties["DeviceID"].Value.ToString(),
          PNPDeviceID = keyboard.Properties["PNPDeviceID"].Value.ToString(),
          Status = keyboard.Properties["Status"].Value.ToString(),
          Name = keyboard.Properties["Name"].Value.ToString()
        });
#pragma warning restore CA1416
      }
    }

    return keyboards;
  }
}