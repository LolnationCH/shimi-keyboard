using System.Runtime.InteropServices;
using System.Text;

class KeyboardLayout
{
  #region DLL Imports
  [DllImport("user32.dll")]
  private static extern bool PostMessage(int hhwnd, uint msg, IntPtr wparam, IntPtr lparam);


  [DllImport("user32.dll")]
  private static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);


  [DllImport("user32.dll")]
  private static extern long GetKeyboardLayoutName(StringBuilder pwszKLID);

  private static uint WM_INPUTLANGCHANGEREQUEST = 0x0050;
  private static int HWND_BROADCAST = 0xffff;
  private static uint KLF_ACTIVATE = 1;
  const int KL_NAMELENGTH = 9;
  #endregion

  /// <summary>
  /// This method is used to switch to a specific layout
  /// </summary>
  /// <param name="layout">The layout code to switch to</param>
  /// <returns>True if the layout was switched, false otherwise</returns>
  public static bool SwitchToLanguage(string languageCode)
  {
    return PostMessage(HWND_BROADCAST,
                         WM_INPUTLANGCHANGEREQUEST,
                      IntPtr.Zero,
                      LoadKeyboardLayout(languageCode, KLF_ACTIVATE));
  }


  /// <summary>
  /// This method is used to get the current layout name.
  /// </summary>
  /// <returns>The current layout as a name</returns>
  public static string GetLayoutName()
  {
    return KeyboardLayoutConverter.CodeToName(GetLayoutCode());
  }

  /// <summary>
  /// This method is used to get the current layout code.
  /// </summary>
  /// <returns>The current layout as a code</returns>
  public static string GetLayoutCode()
  {
    var name = new StringBuilder(KL_NAMELENGTH);
    GetKeyboardLayoutName(name);

    return name.ToString();
  }
}