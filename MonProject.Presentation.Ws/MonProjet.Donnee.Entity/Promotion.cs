using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjet.Donnee.Entity
{
    public class Promotion
    {
        #region Variables membres
        private int m_id;
        private int m_annee_dbt;
        private int m_annee_fin;
        private List<Etudiant> m_List_Etud;
        private int m_nb_etd;
        #endregion

        #region Accesseur
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public int Annee_dbt
        {
            get { return m_annee_dbt; }
            set { m_annee_dbt = value; }
        }

        public int Annee_fin
        {
            get { return m_annee_fin; }
            set { m_annee_fin = value; }
        }

        internal List<Etudiant> List_Etud
        {
            get { return m_List_Etud; }
            set { m_List_Etud = value; }
        }

        public int Nb_etd
        {
            get { return m_nb_etd; }
            set { m_nb_etd = value; }
        }
        #endregion
    }
}
