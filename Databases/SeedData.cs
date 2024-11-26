using GarageApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Databases
{
    internal class SeedData
    {
            public void TestData()
            {
                using AppDbContext db = new AppDbContext();

                Onderdeel antenne = new() { Naam = "Antenne" };
                Onderdeel wiel = new() { Naam = "Wiel" };
                Onderdeel ruitenwisser = new() { Naam = "Ruitenwisser" };
                Onderdeel voorruit = new() { Naam = "Voorruit" };
                Onderdeel deur = new() { Naam = "Deur" };

                Personenauto opel = new() { Merk = "Opel" };
                Personenauto peugeot = new() { Merk = "Peugeot" };
                Personenauto volkswagen = new() { Merk = "Volkswagen" };
                Personenauto citroen = new() { Merk = "Citroën" };

                db.Personenautos.AddRange(new[] { opel, peugeot, volkswagen, citroen });
                db.Onderdelen.AddRange(new[] { antenne, wiel, ruitenwisser, voorruit, deur });

                db.SaveChanges();

                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = opel.Id, OnderdeelId = antenne.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = opel.Id, OnderdeelId = wiel.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = opel.Id, OnderdeelId = voorruit.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = opel.Id, OnderdeelId = deur.Id });

                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = peugeot.Id, OnderdeelId = antenne.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = peugeot.Id, OnderdeelId = wiel.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = peugeot.Id, OnderdeelId = voorruit.Id });
                db.AutoOnderdelen.Add(new AutoOnderdeel() { PersonenAutoId = peugeot.Id, OnderdeelId = deur.Id });

                db.SaveChanges();
            }
    }

}
