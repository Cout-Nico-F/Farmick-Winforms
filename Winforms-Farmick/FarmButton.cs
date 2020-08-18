using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Farmick
{
  //Context
  public class FarmButton : Button
  {
    private State state;
    public State State { get { return state; } set { this.state = value; } }
    public FarmButton (State state)
    {
      this.state = state;
    }
    public void Poke(FarmButton context_FarmButton)
    {
      state.Poke(context_FarmButton);
      //delegate to concreteState
    }
  }
}
