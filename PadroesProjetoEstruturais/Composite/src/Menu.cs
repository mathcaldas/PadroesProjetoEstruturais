namespace Composite;

using Composite.Interfaces;

public class Menu : IMenuComponent
{
    private List<IMenuComponent> components = new List<IMenuComponent>();

    public void Display()
    {
        foreach (var component in components)
        {
            component.Display();
        }
    }

    public void Add(string name, string description)
    {
        components.Add(new MenuItem(name, description));
    }
}