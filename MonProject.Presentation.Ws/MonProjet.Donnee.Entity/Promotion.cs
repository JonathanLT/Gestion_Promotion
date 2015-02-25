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
        private String m_Nom;
        private String m_Prenom;
        private DateTime m_DateNaissance;
        #endregion

        #region Accesseur
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public String Nom
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }

        public String Prenom
        {
            get { return m_Prenom; }
            set { m_Prenom = value; }
        }

        public DateTime DateNaissance
        {
            get { return m_DateNaissance; }
            set { m_DateNaissance = value; }
        }
        #endregion
    }
}
