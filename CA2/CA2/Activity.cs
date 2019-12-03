using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public enum ActivityType { Air, Water, Land }
    public class Activity : IComparable
    {
        public string Name { get; set; }
        public DateTime ActivityDate { get; set; }
        public decimal Cost { get; set; }
        public ActivityType TypeOfActivity { get; set; }
        public string Description { get; set; }

        public Activity(string name, DateTime activityDate, decimal cost, ActivityType type, string description)
        {
            Name = name;
            ActivityDate = activityDate;
            Cost = cost;
            TypeOfActivity = type;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - {ActivityDate}";

        }

        public int CompareTo(object obj)
        {
            Activity that = obj as Activity;
            return this.ActivityDate.CompareTo(that.ActivityDate);
        }

    }


}
