using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Real
{
  internal class User
  {
    public string number;
    public string name;
    public string directory;

    public User[] userList = {
      new User(){number = "001", name = "고성철" , directory = String.Format(@"C:\PDApractice")},
      new User(){number = "002", name = "성철고" , directory = String.Format(@"C:\PDApractice")},
      new User(){number = "003", name = "철성고" , directory = String.Format(@"C:\PDApractice")},
      new User(){number = "004", name = "성고철" , directory = String.Format(@"C:\PDApractice")}
    };
  }
}
