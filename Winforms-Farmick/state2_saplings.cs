﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  class state2_saplings : State
  {
    public state2_saplings(FarmButton context_FarmButton)
    {
      context_FarmButton.Image = Resources.cultivo_terreno;
    }
    public state2_saplings() { }
    public void Poke(FarmButton context_FarmButton)
    {
      if (true)
      {
        context_FarmButton.State = new state1_terrain(context_FarmButton);
        //System.Windows.Forms.MessageBox.Show("Cambio a estado 0");
        context_FarmButton.Image = Resources.cultivo_terreno;
      }
    }
  }
}
