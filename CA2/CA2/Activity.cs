using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public enum ActivityType { Air, Water, Land}
    class Activity : IComparable
    {
        public string name { get; set; }
        public DateTime activityDate { get; set; }
        public decimal cost { get; set; }
        public Activity typeOfActivity { get; set; }
        public string description { get; set; }

    }


    public Activity CompareTo (DateTime date)
    {
        this.CompareTo
    }

}
