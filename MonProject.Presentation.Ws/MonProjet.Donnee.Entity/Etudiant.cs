using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonProjet.Donnee.Entity
{
    public class Etudiant
    {

        #region Variables membres
        private int m_id;
        private String m_Nom;
        private String m_Prenom;
        private DateTime m_DateNaissance;
        #endregion

        public Etudiant(int v_id, string v_nom, string v_prenom, string v_dateNaiss)
        {
            // TODO: Complete member initialization
            Id = v_id;
            Nom = v_nom;
            Prenom = v_prenom;
            DateNaissance = DateTime.Parse(v_dateNaiss);
        }
        public Etudiant(int v_id, string v_nom, string v_prenom, DateTime v_dateNaiss)
        {
            // TODO: Complete member initialization
            Id = v_id;
            Nom = v_nom;
            Prenom = v_prenom;
            DateNaissance = v_dateNaiss;
        }

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
