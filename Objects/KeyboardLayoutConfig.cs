class KeyboardLayoutConfig
{
  public string Layout { get; set; } = KeyboardLayoutConverter.NameToCode("United States");
  public string? DeviceID { get; set; }
  public string PostMessage { get; set; } = "Message to print when switching to this layout";
}