using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_API.Model
{
    public class LocationModel
    {
        /// <summary>
        /// id Location
        /// </summary>
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }


        public string idGroupCompany { get; set; }
        private string ID_GROUP_COMPANY
        {
            get { return idGroupCompany; }
            set { idGroupCompany = value.Trim(); }
        }

        public string address { get; set; }
        private string ADDRESS
        {
            get { return address; }
            set { address = value.Trim(); }
        }

        public string zip { get; set; }
        private string ZIP
        {
            get { return zip; }
            set { zip = value.Trim(); }
        }

        public string extendedStatus { get; set; }
        private string EXTENDED_STATUS
        {
            get { return extendedStatus; }
            set { extendedStatus = value.Trim(); }
        }

        public int count { get; set; }
        private int COUNT
        {
            get { return count; }
            set { count = value; }
        }


    }
}
