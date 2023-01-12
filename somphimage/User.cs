using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somphimage
{
    class User
    {
        private string cdUser = "";
        private string typeUser = "";
        private string prenom = "";
       private string nom = "";
       static public User currentUser = null;
        public User(string cdUser,string typeUser,string prenom,string nom)
        {
            this.cdUser = cdUser;
            this.typeUser = typeUser;
            this.prenom = prenom;
            this.nom = nom;
        }

        public string getCdUser()
        {
            return cdUser;
        }
        public string getTypeUser()
        {
            return typeUser;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public string getNom()
        {
            return nom;
        }
    }
}
