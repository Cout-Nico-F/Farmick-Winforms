using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Farmick
{
  partial class Form1 : Form
  {
    Timer timer_SkipTutorial = new Timer();
    Timer sceneFader = new Timer();

    private void Form1_Load(object sender, EventArgs e)
    {
      sceneFader.Interval = 1;
      sceneFader.Tick += new EventHandler(fadeIn);
      sceneFader.Start();
    }
    void fadeIn(object sender, EventArgs e)
    {
      if (this.Opacity >= 1)
        sceneFader.Stop();
      else
        this.Opacity += 0.016;
    }
    private void SkipTutorial(object sender, EventArgs e)
    {
      timer_SkipTutorial.Stop();
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
      //(sender as Button).Dispose();
      btn_Tutorial.Dispose();
    }
    private void Hold_SkipTutorial()
    {
      System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
      timer_SkipTutorial = new Timer();
      timer_SkipTutorial.Interval = 2000;
      timer_SkipTutorial.Tick += SkipTutorial;
      timer_SkipTutorial.Start();
    }
  }
}
