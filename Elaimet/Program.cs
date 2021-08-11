using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            Hevonen heppa = new Hevonen();
            Hevonen histamiini = new Hevonen();
            //Tulosta olion nimi ja paino
            Console.WriteLine(heppa.Nimi);
            Console.WriteLine(heppa.Paino);
            //Muuta olion nimeä ja painoa
            heppa.Nimi = "Koni";
            heppa.Paino = 120;

            histamiini.Nimi = "Histamiini";
            histamiini.Paino = 89;
            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine(heppa.Nimi);
            Console.WriteLine(heppa.Paino);
            Console.WriteLine(histamiini.Nimi);
            Console.WriteLine(histamiini.Paino);
            Console.ReadLine();
        }
    }
}
