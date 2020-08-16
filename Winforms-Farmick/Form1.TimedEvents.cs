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
    private Timer t = new Timer();

    private void ChangeState(object sender, EventArgs e)
    {
      t.Stop();
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
      actualButton.Image = Resources.cultivo_crecido;//placeholder action.
    }
    private void ChangeState_Hold(Button button)
    {
      actualButton = button ;
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
      t = new Timer();
      t.Interval = 2000;
      t.Tick += ChangeState;
      t.Start();
    }

  }
}
