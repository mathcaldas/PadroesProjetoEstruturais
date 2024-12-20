using System;
using Composite.Interfaces;

namespace Composite
{
    public class MenuItem : IMenuComponent
    {
        private string _name;
        private string _description;

        public MenuItem(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Display()
        {
            Console.WriteLine($"Menu Item: {_name}, Description: {_description}");
        }
    }
}