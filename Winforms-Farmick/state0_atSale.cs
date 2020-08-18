using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Farmick
{
  class state0_atSale : State
  {
    //i need to change the sprite based on the state too

    public void Poke(FarmButton context_FarmButton)
    {
      //you can buy this farms holding click spending coins.
      //(you have enough coins)? change_to_state1 : you_cant_buy_message
      if (true)
      {
        context_FarmButton.State = new state1_terrain();
        System.Windows.Forms.MessageBox.Show("Cambio a estado 1");
      }
    }
  }
}
