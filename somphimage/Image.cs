using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somphimage
{
    class Image
    {
        private int noImg;
        private int cdUser;
        private string description;
        private DateTime dateFermeture;

        public Image(int unNoImg, int uncdUser,string uneDescription, DateTime uneDateFermeture)
        {
            noImg = unNoImg;
            cdUser = uncdUser;
            description = uneDescription;
            dateFermeture = uneDateFermeture;
        }
    }
}
