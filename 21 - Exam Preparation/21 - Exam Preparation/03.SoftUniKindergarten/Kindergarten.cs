using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace SoftUniKindergarten
{
	public class Kindergarten
	{
		private string name;
		private int capacity;
		private List<Child> registry;

		public Kindergarten(string name, int capacity)
		{
			Name = name;
			Capacity = capacity;
			Registry = new List<Child>();
		}

		public string Name

		{
			get { return name; }
			set { name = value; }
		}

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}
		public List<Child> Registry
		{
			get { return registry; }
			set { registry = value; }
		}
		public int ChildrenCount => registry.Count;

		public bool AddChild(Child child)
		{
			if (Registry.Count < Capacity)
			{
				Registry.Add(child);
				return true;
			}
			return false;
		}

		public bool RemoveChild(string childFullName)
		{
			return Registry.Remove(Registry.FirstOrDefault(c => c.FirstName == childFullName.Split(" ")[0]
															&& c.LastName == childFullName.Split(" ")[1]));
		}

		public Child GetChild(string childFullName)
		{
			return this.Registry.FirstOrDefault(x => x.FirstName == childFullName.Split(" ")[0]
												  && x.LastName == childFullName.Split(" ")[1]);

		}

        public string RegistryReport()
        {
            List<Child> sortedChildren = this.Registry.OrderByDescending(x => x.Age)
														.ThenBy(x => x.LastName)	
														.ThenBy(x => x.FirstName).ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {this.Name}:");

            foreach (var child in sortedChildren)
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
