using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper2MVC.Models
{
    public class GroupMeetingView
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }
        public string GroupMeetingLeadName { get; set; }
        public string TeamLeadName { get; set; }
        public string Description { get; set; }

        public string GroupMeetingDate { get; set; }
        public string Lead => $"{TeamLeadName} - {GroupMeetingLeadName}";

        public int RoomID { get; set; }
        public string RoomName { get; set; }
    }
}
