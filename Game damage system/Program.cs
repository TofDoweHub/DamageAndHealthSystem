using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_damage_system
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int damageDivider = 2;
			int armorDamageMultiplier = 2;

			Console.Write("Введите кол-во хп:");
			int health = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите кол-во щита:");
			int armor = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите кол-во дамага:");
			int damage = Convert.ToInt32(Console.ReadLine());

			HealthSystem(health, armor, damage, damageDivider, armorDamageMultiplier);

			Console.ReadLine();
		}

		static void HealthSystem(int health, int armor, int damage, int armorDamageMultiplier, int damageDivider)
		{
			health += (armor / damageDivider) - damage;
			armor -= damage * armorDamageMultiplier;
			if (armor <= 0)
			{
				armor = 0;
			}
			else if (health > 100)
			{
				health = 100;
			}

			if (health <= 0)
			{
				Console.WriteLine("Убил!");
			}
			else
			{
				Console.Write($"осталось {health} хп и {armor} щита!");
			}
			// о боже как же ужасно это сделано, но зато работает
		}
	}
}
