using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


namespace Real
{
  internal class User
  {
    public string number { get; set; }
    public string name { get; set; }
    public string directory { get; set; }
    
    //public User[] userList = {
    //    new User(){number = "001", name = "고성철" , directory = String.Format(@"C:\PDApractice")},
    //   new User(){number = "002", name = "성철고" , directory = String.Format(@"C:\PDApractice")},
    //  new User(){number = "003", name = "철성고" , directory = String.Format(@"C:\PDApractice")},
    //  new User(){number = "004", name = "성고철" , directory = String.Format(@"C:\PDApractice")}
    //};

   List<User> user = new List<User>()
  {
    new User {number = "001" , name = "고성철", directory = String.Format(@"C:\PDApractice")},
    new User {number = "002" , name = "성철", directory = String.Format(@"C:\PDApractice")},
    new User {number = "003" , name = "철성", directory = String.Format(@"C:\PDApractice")},
    new User {number = "004" , name = "철성고", directory = String.Format(@"C:\PDApractice")}

  };

    //List<User> user = new List<User>();
    //user.Add(new User() { number = "001", name = "고성철", .directory = String.Format(@"C:\PDApractice")} );





   // User[] arr = user.ToArray(); 






  }
}
