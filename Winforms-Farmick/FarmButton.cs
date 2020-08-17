using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Farmick
{
  //Context
  class FarmButton : Button, IChange
  {
    public void Poke()
    {
      MessageBox.Show("Increible");
    }
  }
}
