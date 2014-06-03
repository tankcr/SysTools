using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace SysTools
{
    public class Domains
    {
        string domainName;

        public string DomainName
        {
            get { return domainName; }
            set { domainName = value; }
        }

        public Domains()
        {

        }
    }
    public class GetDomains
    {
        public static List<Domains> GetDomainNames()
        {
            List<Domains> domains = new List<Domains>();
            GetDomains DomainNames = new GetDomains();
/*            string domain = Environment.UserDomainName;
            DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain);
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=domain)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;
*/            using (var forest = Forest.GetCurrentForest())
            {
                foreach (Domain mydomain in forest.Domains)
                {
                    domains.Add(new Domains() { DomainName = mydomain.Name });
                    mydomain.Dispose();
                }
            }
            return domains;
        }
    }
}
