using System.Runtime.CompilerServices;
namespace ButtonEvent;
public class Button
{
    public event EventHandler? Clicked = null;
    public void PressButton()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}
public class User
{
    public void PerformAction(object sender, EventArgs e)
    {
        Console.WriteLine("Action Performed!");
    }
}
public class MainProgram
{
    public static void Main()
    {
        Button button = new Button();
        User user = new User();
        //Subscribe the event
        button.Clicked += user.PerformAction;
        button.PressButton();
    }
}