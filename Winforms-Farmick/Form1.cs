using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Opacity = 0;
    }

    private void btn_farm_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ChangeState_Hold(sender as Button);
      }  
    }

    private void btn_farm_MouseUp(object sender, MouseEventArgs e)
    {
      timer_hold.Stop();
      timer_hold = null;
    }

    private void btn_Tutorial_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Hold_SkipTutorial();
      }
    }

    private void btn_Tutorial_MouseUp(object sender, MouseEventArgs e)
    {
      timer_SkipTutorial.Stop();
      timer_SkipTutorial = null;
    }
  }
}
