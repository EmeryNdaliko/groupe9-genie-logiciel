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
                    Console.WriteLine("choix Invalide!!!!");
                    break;
                }

                if(choix_db == 1)
                {
                    Console.WriteLine("Quel Class voulez-vous Utiliser??");
                    Console.WriteLine("1 [Abtaite]\n2 [Interface]");
                    choix_class = Convert.ToInt32(Console.ReadLine());
                    if (choix_class != 1 && choix_class != 2)
                    {
                        Console.WriteLine("choix Invalide!!!!");
                        break;
                    }
                    if(choix_class == 1)
                    {
                        Motorcycle m1 = new Motorcycle("HONDA", "TVS", "Red", "4537788egte");
                        Cars c1 = new Cars("BULMI", "TVS", "Red", "u885ufjfnfnf");
                        Motorcycle m2 = new Motorcycle("HAUJUE", "TVS", "Red", "4537788egte");
                        Cars c2 = new Cars("bUGATI", "AUDI", "Red", "u885ufjfnfnf");
                        m1.Add(choix_db);
                        c1.Add(choix_db);
                        m2.Add(choix_db);
                        c2.Add(choix_db);
                        m1.showDetails(choix_db, 2);
                        c1.showDetails(choix_db, 3);
                        m2.showDetails(choix_db, 2);
                        c2.showDetails(choix_db, 3);
                    }

                    if (choix_class == 2)
                    {
                        Interface.Motorcycle m2 = new Interface.Motorcycle("UJ898", "HAUJIN", "Red", "4537788egte");
                        Interface.Cars c2 = new Interface.Cars("RANG ROVER", "TOYOTA", "Metal", "oo9ieiie");
                        m2.Add(choix_db);
                        c2.Add(choix_db);
                        m2.showDetails(choix_db, 3);
                        c2.showDetails(choix_db, 4);
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
                        Motorcycle m1 = new Motorcycle("Yamaya", "TVS", "Red", "4537788egte");
                        Cars c1 = new Cars("kj56", "TVS", "Red", "u885ufjfnfnf");
                        m1.Add(choix_db);
                        c1.Add(choix_db);
                    }

                    if (choix_class == 2)
                    {
                        Interface.Motorcycle m2 = new Interface.Motorcycle("Honda", "yamaha", "Red", "4537788egte");
                        Interface.Cars c2 = new Interface.Cars("fgt34", "WOLVSWAGGEN", "Metal", "oo9ieiie");
                        m2.Add(choix_db);
                        c2.Add(choix_db);
                    }

                }

                Console.WriteLine("Voulez-vous Recommencer [Y/N]??");
                rep = Console.ReadLine();

            } while ((rep == "Y" || rep == "y") && (rep != "N" || rep != "n"));


            Console.ReadLine();
        }
    }
}
