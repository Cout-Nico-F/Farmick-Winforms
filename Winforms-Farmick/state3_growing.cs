using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  class state3_growing : State
  {
    public state3_growing(FarmButton context_FarmButton)
    {
      context_FarmButton.Image = Resources.cultivo_crecido;
    }
    public state3_growing() { }
    public void Poke(FarmButton context_FarmButton)
    {
      if (true)
      {
        context_FarmButton.State = new state1_terrain(context_FarmButton);
      }
    }
  }
}
