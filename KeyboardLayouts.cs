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

  public static bool SwitchToLanguage(string languageCode)
  {
    return PostMessage(HWND_BROADCAST,
                         WM_INPUTLANGCHANGEREQUEST,
                      IntPtr.Zero,
                      LoadKeyboardLayout(languageCode, KLF_ACTIVATE));
  }


  public static string GetLayoutName()
  {
    return KeyboardLayoutConverter.CodeToName(GetLayoutCode());
  }

  public static string GetLayoutCode()
  {
    var name = new StringBuilder(KL_NAMELENGTH);
    GetKeyboardLayoutName(name);

    return name.ToString();
  }
}