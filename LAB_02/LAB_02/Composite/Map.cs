using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Composite
{
    class Map : IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();

        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public string Title { get; set; }

        public void Draw()
        {
            foreach (var component in _map)
            {
                component.Draw();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public IComponent Find(string title)
        {
            foreach (var component in _map)
            {
                if (component.Find(title) != null)
                    return component;
            }
            return null;
        }
    }
}
