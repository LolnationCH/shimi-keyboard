class LayoutChanges
{
  public bool changed = false;
  public string layout = string.Empty;
  public string previousLayout = string.Empty;
  public bool changedDuringCurrentIteration = false;

  public void Reset()
  {
    KeyboardLayout.SwitchToLanguage(previousLayout);
    Console.WriteLine($"Switched backed to the previous layout : {KeyboardLayoutConverter.CodeToName(previousLayout)}");

    changed = false;
    layout = string.Empty;
    previousLayout = string.Empty;
    changedDuringCurrentIteration = false;
  }

  public bool ShouldReset()
  {
    return changed && !changedDuringCurrentIteration;
  }

  public void Changing(string previousLayout, string layout)
  {
    changed = true;
    this.previousLayout = previousLayout;
    this.layout = layout;
    changedDuringCurrentIteration = true;
  }
}