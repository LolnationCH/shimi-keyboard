struct KeyboardInfo
{
  public string? Caption;
  public string? Description;
  public string? DeviceID;
  public string? PNPDeviceID;
  public string? Status;
  public string? Name;

  public override string ToString()
  {
    return $"{Name} : {Description} => {DeviceID} ({Status})";
  }
}