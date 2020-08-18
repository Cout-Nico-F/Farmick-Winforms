using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Farmick
{
  class state1_terrain : State
  {
    public void Poke(FarmButton context_FarmButton)
    {
      if (true)
      {
        context_FarmButton.State = new state0_atSale();
        System.Windows.Forms.MessageBox.Show("Cambio a estado 0");
      }
    }
  }
}
