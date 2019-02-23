using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_module04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество мотоциклов: ");
            int countOfmotobikes = Convert.ToInt32(Console.ReadLine());
            Motobike[] motobikes = new Motobike[countOfmotobikes];
            try
            {
                if (countOfmotobikes < 5)
                {
                    throw new Exception("Мотоцилков должно быть больше 4-ех");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
            for (int i = 0; i < countOfmotobikes; i++)
            {
                motobikes[i] = new Motobike();
                Console.Write("Введите название мотоцикла: ");
                motobikes[i].Name = Console.ReadLine();
                Console.Write("Введите цвет мотоцикла: ");
                motobikes[i].Color = Console.ReadLine();
                Console.Write("Введите объём двигателя мотоцикла: ");
                motobikes[i].EngineCapacity = double.Parse(Console.ReadLine());
                Console.Write("Введите год выпуска мотоцикла: ");
                motobikes[i].Year = int.Parse(Console.ReadLine());
                Console.Write("Введите количество лошадинных сил: ");
                motobikes[i].MaxSpeed = int.Parse(Console.ReadLine());
                motobikes[i] = new Motobike(motobikes[i].Name, motobikes[i].Color, motobikes[i].EngineCapacity, motobikes[i].Year, motobikes[i].MaxSpeed);
                Console.WriteLine("-------------------------------------");

            }
            Console.WriteLine("Машины в гараже: \n");
            for (int i = 0; i < countOfmotobikes; i++)
            {
                Console.WriteLine(motobikes[i].showMotobikeInfo());
                Console.WriteLine("-------------------------------------");
            }
            Console.Read();
        }
    }
}
