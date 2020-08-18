using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  class state1_terrain : State
  {

    public state1_terrain(FarmButton context_FarmButton)
    {
      context_FarmButton.Image = Resources.cultivo_arado;
    }
    public state1_terrain() { }
    public void Poke(FarmButton context_FarmButton)
    {
      if (true)
      {
        context_FarmButton.State = new state2_saplings(context_FarmButton);
        context_FarmButton.Image = Resources.cultivo_sembrado;
       // System.Windows.Forms.MessageBox.Show("Cambio a estado 2");
      }
    }
  }
}
