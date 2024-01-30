using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Models
{
    public class IssueModel
    {
        public string Header { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public DateTime Datetime { get; set; }
    }
}


