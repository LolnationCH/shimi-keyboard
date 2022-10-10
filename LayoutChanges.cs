// This class is used to track changes to the keyboard layout.
class LayoutChanges
{
  public bool changed = false;
  public string layout = string.Empty;
  public string previousLayout = string.Empty;
  public bool changedDuringCurrentIteration = false;

  /// <summary>
  /// Called when we want to reset the layout to the previous one
  /// </summary>
  public void Reset()
  {
    // Before resetting, we need to put back the previous layout as the current one.
    KeyboardLayout.SwitchToLanguage(previousLayout);
    Console.WriteLine($"Switched backed to the previous layout : {KeyboardLayoutConverter.CodeToName(previousLayout)}");

    changed = false;
    layout = string.Empty;
    previousLayout = string.Empty;
    changedDuringCurrentIteration = false;
  }

  /// <summary>
  /// This function calculate if we should reset to the previous layout. We know we should reset if the layout didn't changed during the current iteration.
  /// </summary>
  public bool ShouldReset()
  {
    return changed && !changedDuringCurrentIteration;
  }

  /// <summary>
  /// This method is used to set the members of the class when a change is detected.
  /// </summary>
  public void Changing(string previousLayout, string layout)
  {
    changed = true;
    this.previousLayout = previousLayout;
    this.layout = layout;
    changedDuringCurrentIteration = true;
  }
}