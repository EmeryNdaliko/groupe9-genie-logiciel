using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfacesAndAbstactClasses.Abstact;
using interfacesAndAbstactClasses.Cofig;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using System.Data;

namespace interfacesAndAbstactClasses
{
    class Program
    {   
        static void Main(string[] args)
        {
            String rep = "";
            int choix_db,choix_class;
            do
            {
                Console.WriteLine("Quel base donnee voulez-vous Utiliser??");
                Console.WriteLine("1 [Sql Server]\n2 [MySql]");
                choix_db = Convert.ToInt32(Console.ReadLine());

                if(choix_db != 1 && choix_db != 2)
                {
                    Console.WriteLine("Votre Choix est Invalide!!!!");
                    break;
                }

                if(choix_db == 1)
                {
                    Console.WriteLine("Quel Class voulez-vous Utiliser??");
                    Console.WriteLine("1 [Abtaite]\n2 [Interface]");
                    choix_class = Convert.ToInt32(Console.ReadLine());
                    if (choix_class != 1 && choix_class != 2)
                    {
                        Console.WriteLine("Votre Choix est Invalide!!!!");
                        break;
                    }
                    if(choix_class == 1)
                    {
                        Motorcycle m1 = new Motorcycle("HONDA", "TVS", "Red", "4537788egte");
                        Cars c1 = new Cars("BULMI", "TVS", "Red", "u885ufjfnfnf");
                        Motorcycle m2 = new Motorcycle("HAUJUE", "TVS", "Red", "4537788egte");
                        Cars c2 = new Cars("bUGATI", "AUDI", "Red", "u885ufjfnfnf");
                        Motorcycle m3 = new Motorcycle("GLG", "GT", "Red", "4537788egte");
                        Cars c3 = new Cars("BUGATI", "TOYOTA", "Red", "u885ufjfnfnf");
                        Motorcycle m4 = new Motorcycle("HAUJUE", "TVS", "Red", "4537788egte");
                        Cars c4 = new Cars("bUGATI", "AUDI", "Red", "u885ufjfnfnf");
                        m1.Add(choix_db);
                        c1.Add(choix_db);
                        m2.Add(choix_db);
                        c2.Add(choix_db);
                        m3.Add(choix_db);
                        c3.Add(choix_db);
                        m1.showDetails(choix_db, 1);
                        c1.showDetails(choix_db, 1);
                        m2.showDetails(choix_db, 2);
                        c2.showDetails(choix_db, 2);
                        m3.showDetails(choix_db, 3);
                        c3.showDetails(choix_db, 3);
                    }

                    if (choix_class == 2)
                    {

                        Interface.Motorcycle m4 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c4 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        Interface.Motorcycle m5 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c5 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        Interface.Motorcycle m6 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c6 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        m4.Add(choix_db);
                        c4.Add(choix_db);
                        m5.Add(choix_db);
                        c5.Add(choix_db);
                        m6.Add(choix_db);
                        c6.Add(choix_db);
                        m4.showDetails(choix_db, 4);
                        c4.showDetails(choix_db, 4);
                        m5.showDetails(choix_db, 5);
                        c5.showDetails(choix_db, 5);
                        m6.showDetails(choix_db, 6);
                        c6.showDetails(choix_db, 6);

                    }
                }
                
                if(choix_db == 2)
                {
                    Console.WriteLine("Quel Class voulez-vous Utiliser??");
                    Console.WriteLine("1 [Abtaite]\n2 [Interface]");
                    choix_class = Convert.ToInt32(Console.ReadLine());
                    if (choix_class != 1 && choix_class != 2)
                    {
                        Console.WriteLine("choix Invalide!!!!");
                    }
                    if (choix_class == 1)
                    {
                        Motorcycle m1 = new Motorcycle("HONDA", "TVS", "Red", "4537788egte");
                        Cars c1 = new Cars("BULMI", "TVS", "Red", "u885ufjfnfnf");
                        Motorcycle m2 = new Motorcycle("HAUJUE", "TVS", "Red", "4537788egte");
                        Cars c2 = new Cars("bUGATI", "AUDI", "Red", "u885ufjfnfnf");
                        Motorcycle m3 = new Motorcycle("GLG", "GT", "Red", "4537788egte");
                        Cars c3 = new Cars("BUGATI", "TOYOTA", "Red", "u885ufjfnfnf");
                        Motorcycle m4 = new Motorcycle("HAUJUE", "TVS", "Red", "4537788egte");
                        Cars c4 = new Cars("bUGATI", "AUDI", "Red", "u885ufjfnfnf");
                        m1.Add(choix_db);
                        c1.Add(choix_db);
                        m2.Add(choix_db);
                        c2.Add(choix_db);
                        m3.Add(choix_db);
                        c3.Add(choix_db);
                        m1.showDetails(choix_db, 1);
                        c1.showDetails(choix_db, 1);
                        m2.showDetails(choix_db, 2);
                        c2.showDetails(choix_db, 2);
                        m3.showDetails(choix_db, 3);
                        c3.showDetails(choix_db, 3);
                    }

                    if (choix_class == 2)
                    {
                        Interface.Motorcycle m4 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c4 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        Interface.Motorcycle m5 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c5 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        Interface.Motorcycle m6 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c6 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        m4.Add(choix_db);
                        c4.Add(choix_db);
                        m5.Add(choix_db);
                        c5.Add(choix_db);
                        m6.Add(choix_db);
                        c6.Add(choix_db);
                        m4.showDetails(choix_db, 4);
                        c4.showDetails(choix_db, 4);
                        m5.showDetails(choix_db, 5);
                        c5.showDetails(choix_db, 5);
                        m6.showDetails(choix_db, 6);
                        c6.showDetails(choix_db, 6);
                    }

                }

                Console.WriteLine("Voulez-vous Recommencer [Y/N]??");
                rep = Console.ReadLine();

            } while ((rep == "Y" || rep == "y") && (rep != "N" || rep != "n"));


            Console.ReadLine();
        }
    }
}
