using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices; 

namespace GetLogs
{
    public class Computers
    {
        string computerName;

        public string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }

        public Computers()
        {

        }
    }
    public class GetComputers
    {
        public static List<Computers> GetComputerNames(string domain, string systemtype)
        {
            List<Computers> computers = new List<Computers>();
            GetComputers ComputerNames = new GetComputers();
            //string domain = Environment.UserDomainName;
            DirectoryEntry entry = new DirectoryEntry("LDAP://"+domain);
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=computer)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;
            foreach (SearchResult resEnt in mySearcher.FindAll())
            {
      //          List<object> ComputerObject;
      //          List<str>

                if (resEnt.Properties["operatingsystem"] != null && resEnt.Properties["operatingsystem"].Count > 0)
                {
                string OS = resEnt.Properties["operatingsystem"][0].ToString();
                string type = "";
                if (systemtype == "Servers" && OS.Contains("Server"))
                {
                    string ComputerName = resEnt.GetDirectoryEntry().Name;

                    if (ComputerName.StartsWith(type))
                    {
                        if (ComputerName.StartsWith("CN="))
                            ComputerName = ComputerName.Remove(0, "CN=".Length);
                        computers.Add(new Computers() { ComputerName = ComputerName });
                    }
                }
                else if (systemtype == "Computers" && !OS.Contains("Server"))
                {
                    string ComputerName = resEnt.GetDirectoryEntry().Name;

                    if (ComputerName.StartsWith(type))
                    {
                        if (ComputerName.StartsWith("CN="))
                            ComputerName = ComputerName.Remove(0, "CN=".Length);
                        computers.Add(new Computers() { ComputerName = ComputerName });
                    }
                }
                }
            }

            mySearcher.Dispose();
            entry.Dispose();

            return computers.OrderBy(x=>x.ComputerName).ToList<Computers>();
        }
    }
}
