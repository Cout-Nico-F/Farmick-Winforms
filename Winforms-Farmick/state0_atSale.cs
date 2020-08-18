using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  class state0_atSale : State
  {
    public state0_atSale (FarmButton context_FarmButton)
    {
      context_FarmButton.Image = Resources.terrenoAlaventa; 
    }
    public state0_atSale() { }
    public void Poke(FarmButton context_FarmButton)
    {
      //you can buy this farms holding click spending coins.
      //(you have enough coins)? change_to_state1 : you_cant_buy_message
      if (Player.Instance.Coins >= 100)
      {
        context_FarmButton.State = new state1_terrain(context_FarmButton);
        Player.Instance.Coins -= 100;
        Application.OpenForms["Form1"].Controls["label_coins"].Text = Player.Instance.Coins.ToString();
      }
      else
        //Sound indicating error or coins not enough
        ;
    }
  }
}
