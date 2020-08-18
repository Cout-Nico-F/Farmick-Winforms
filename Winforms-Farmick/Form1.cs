using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Farmick.Properties;

namespace Winforms_Farmick
{
  public partial class Form1 : Form
  {
    
    public Form1()
    {
      InitializeComponent();
      label_coins.Text = Player.Instance.Coins.ToString();
      this.Opacity = 0;
      btn_Tutorial.BringToFront();
      InitFarmButtons();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
    }

    private void btn_farm_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ChangeState_Hold(sender as FarmButton);
      }  
    }

    private void btn_farm_MouseUp(object sender, MouseEventArgs e)
    {
      timer_hold.Stop();
      timer_hold = null;
    }

    private void btn_Tutorial_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Hold_SkipTutorial();
      }
    }
    private void btn_Tutorial_MouseUp(object sender, MouseEventArgs e)
    {
      timer_SkipTutorial.Stop();
      timer_SkipTutorial = null;
    }

    private void InitFarmButtons()
    {
      this.btn_farm1.State = new state0_atSale();
      this.btn_farm2.State = new state0_atSale();
      this.btn_farm3.State = new state1_terrain();
      this.btn_farm4.State = new state1_terrain();
      this.btn_farm5.State = new state0_atSale();
      this.btn_farm6.State = new state0_atSale();
      this.btn_farm7.State = new state0_atSale();
      this.btn_farm8.State = new state0_atSale();
      this.btn_farm9.State = new state0_atSale();
      this.btn_farm10.State = new state0_atSale();
      this.btn_farm11.State = new state0_atSale();
      this.btn_farm12.State = new state0_atSale();
    }

    public string LabelCoins
    {
      get { return label_coins.Text; }
      set {label_coins.Text = value.ToString(); }
    }
  }
}
