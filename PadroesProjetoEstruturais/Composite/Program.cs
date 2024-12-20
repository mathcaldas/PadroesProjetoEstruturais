using System;
using Composite.Interfaces;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Add("Item 1", "Description 1");
            menu.Add("Item 2", "Description 2");

            menu.Display();
        }
    }
}