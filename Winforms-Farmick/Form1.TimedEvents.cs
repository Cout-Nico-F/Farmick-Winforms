using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick 
{
  partial class Form1 : Form
  {
    private Button actualButton ;
    private Timer timer_hold = new Timer();

    private void ChangeState(object sender, EventArgs e)
    {
      timer_hold.Stop();
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
      //Poke(actualButton);
      actualButton.Image = Resources.cultivo_crecido;//placeholder action.
    }
    private void ChangeState_Hold(Button button)
    {
      actualButton = button ;
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
      timer_hold = new Timer();
      timer_hold.Interval = 1600;
      timer_hold.Tick += ChangeState;
      timer_hold.Start();
    }
  }
}
