using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MonProjet.Data.Core
{
    public class Data
    {
        private static Donnee.Entity.Promotion m_DUT = new Donnee.Entity.Promotion(001, 2013, 2015);

        public static void start()
        {
            m_DUT.List_Etud.Add(new Donnee.Entity.Etudiant(0004, "LEFEVRE", "Antoine", "19/06/1993"));
            m_DUT.List_Etud.Add(new Donnee.Entity.Etudiant(0001, "LOQUET", "Jonathan", "18/07/2013"));
            m_DUT.List_Etud.Add(new Donnee.Entity.Etudiant(0003, "VACANDARD", "Clément", "13/02/2016"));
            m_DUT.List_Etud.Add(new Donnee.Entity.Etudiant(0002, "DOE", "John", "01/01/1900"));
            Serializer(m_DUT);
        }

        public static Boolean Serializer(Donnee.Entity.Promotion p_Promotion)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Donnee.Entity.Promotion));
                StreamWriter wr = new StreamWriter("Promotion.xml");
                xs.Serialize(wr, p_Promotion);
                Console.WriteLine("Ok");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
                return false;
            }
        }

        public static void Deserializer()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Donnee.Entity.Promotion));
                using (StreamReader rd = new StreamReader("Promotion.xml"))
                {
                    Donnee.Entity.Promotion p = xs.Deserialize(rd) as Donnee.Entity.Promotion;
                    Console.WriteLine("Id : {0}", p.Id);
                    Console.WriteLine("Année : {0}/{1}", p.Annee_dbt, p.Annee_fin);
                    Console.WriteLine("Nombre étudiants : {0}", p.Nb_etd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
        }

            

        

        
    }
}
