using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Farmick
{
  class state0_atSale : IChange
  {
    public void Poke()
    {
      //you can buy this farms holding click spending coins.
      //(you have enough coins)? change_to_state1 : you_cant_buy_message
    }
  }
}
