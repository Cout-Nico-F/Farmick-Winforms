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
    private int coins;
    public int Coins
    { 
      get { return coins; } 
      set { coins = value; }
    }
    public Form1()
    {
      InitializeComponent();
      this.coins = 200;
      label1.Text = coins.ToString();
      this.Opacity = 0;
      btn_Tutorial.BringToFront();

    }

    public bool HasCoins(int ammount)
    {
      if (coins >= ammount)
      {
        return true;
      }
      else return false;
    }

    private void btn_farm_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ChangeState_Hold(sender as FarmButton);
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
