using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaniKaniCritical.Models
{

    public class UserInformation
    {
        public string username { get; set; }
        public string gravatar { get; set; }
        public int level { get; set; }
        public string title { get; set; }
        public string about { get; set; }
        public string website { get; set; }
        public string twitter { get; set; }
        public int topics_count { get; set; }
        public int posts_count { get; set; }
        public int creation_date { get; set; }
        public int? vacation_date { get; set; }
    }

    public class LearningPoint
    {
        public string type { get; set; }
        public string character { get; set; }
        public string meaning { get; set; }
        public string onyomi { get; set; }
        public string kunyomi { get; set; }
        public string important_reading { get; set; }
        public int level { get; set; }
        public object nanori { get; set; }
        public string percentage { get; set; }
    }

    public class JsonData
    {
        public UserInformation user_information { get; set; }
        public List<LearningPoint> requested_information { get; set; }
    }
}
