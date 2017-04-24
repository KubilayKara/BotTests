using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraSimulation
{
    public class Issue
    {
        public string IssueCode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Deadline { get; set; }
        public string AssigneeCode { get; set; }
        public IssueStatus Status { get; set; }

    }

    public  enum IssueStatus
    {
        None,
        Open,
        Inprogress,
        Closed
    }
}
