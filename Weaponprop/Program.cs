using Weaponprop.Modules;
namespace Weaponprop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Weapon weapon = new Weapon(30,20,3,"single");
            Console.WriteLine("-----Poligona xos gelmisiniz-----\n");
            do
            {
                Console.WriteLine("\n0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");
                Console.WriteLine("7 - Redakte et\n");
                Console.Write("Seciminizi edin: ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {

                    case 0:
                        weapon.Information();
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBulletCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("\nGoodbye");
                        check = false;
                        break;
                    case 7:
                        weapon.ChangeInfo();
                        break;
                }
            } while (check);
        }
    }
}