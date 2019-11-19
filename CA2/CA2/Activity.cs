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
        public string Name { get; set; }
        protected DateTime ActivityDate { get; set; }
        public decimal Cost { get; set; }
        public Activity TypeOfActivity { get; set; }
        public string Description { get; set; }

        public int CompareTo(object obj)
        {
            Activity that = obj as Activity;
            return this.ActivityDate.CompareTo(that.ActivityDate);


        }

        List<Activity> Activities = new List<Activity>();
    }


}
