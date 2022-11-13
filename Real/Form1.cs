using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real
{
  public partial class Form1 : Form
  {
    const string DataFileName = "data.txt";

    /**
     * 
     * Constructor
     */

    Utils util = new Utils();

    public Form1()
    {
      InitializeComponent();

      if(CheckExistDataFile())
      {
        string text = ReadDataFile();
        UITextBox.Text = text;
      }
      else
      {
        TouchDataFile();
      }
    }

    /**
     * 
     * Component Events
     */

    private void UISaveButton_Click (object sender, EventArgs e)
    {
      WriteDataFile();
    }

    /**
     * 
     * Custom private methods :D
     */

    private bool CheckExistDataFile()
    {
      bool exist = File.Exists(DataFileName);
      return exist;
    }

    private string ReadDataFile()
    {
      string text = System.IO.File.ReadAllText(DataFileName);
      return text;
    }

    private void TouchDataFile()
    {
      File.WriteAllText(DataFileName, "");
    }

    private void WriteDataFile()
    {
      File.WriteAllText(DataFileName, UITextBox.Text);
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void RecieveButton_Click(object sender, EventArgs e)
    {
      util.GetUserList();
    }
  }
}
