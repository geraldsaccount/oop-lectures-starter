// Author: Gérald Montúfar
// Created: 14.10.2024

namespace _1_ClassQuest {
	public abstract class Item {
		public string Name { get; }
		public float Durability { get; protected set; }

		public Item(string name) {
			Name = name;
		}
	}
}

