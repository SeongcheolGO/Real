using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Real
{
  internal class Utils
  {
    public void ConnectPDA()
    {

    }

    public void TransferFileToPDA(string filename)
    {
      string preTransfile = @"C:\Users\tjdcj\Desktop\Workspace\Data.WASAP.sqlite";
      ConnectionState deviceConn = ConnectionState.Open;


      
    }

    public void ReceiveFileToPDA(string filename)
    {
      string receiveFile = @"내 PC\PM45\내부 공유 저장용량\WASAP\output\WASAP.sqlite";


    }

    public void RegisterUser(string number, string name, string directory)
    {
       string UserDirectory = string.Format(@"C:\PDApractice\'{0}'-'{1}' ",number, name);
      if (!Directory.Exists(UserDirectory))
      {
        Directory.CreateDirectory(UserDirectory);
      }



    }

    public string OpenSelectDirectory()
    {
      string UserPath = @"C:\PDApractice\001-고성철";
      if(!Directory.Exists(UserPath))
      { 
        Directory.CreateDirectory(UserPath);
      }



      return null;
    }

    public void UpdateUser(string number, string name, string directory)
    {

    }

    public List<User> GetUserList() //리스트 제네릭 사용한거 확인 하기 
    {
      try
      {

        IEnumerable<User> userList =
        from User in User.user1
        where User.name.Length > 2
        select User;

      
        foreach (User getlist in userList)
        {
          MessageBox.Show(String.Format("{0}-{1}", getlist.number, getlist.name));
        }
      
      }catch
      {
        MessageBox.Show("3글자 이상이 없습니다.");
      }


      return null;
    }

  }
}
