﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Farmick
{
  public class Player
  {
    private int coins;
    public int Coins
    {
      get { return coins; }
      set { coins = value; }
    }
    private Player()
    {
      this.coins = 200;
    }

    private readonly static Player _instance = new Player();

    public static Player Instance
    {
      get
      {
        return _instance;
      }
    }
    public bool HasCoins(int ammount)
    {
      if (coins >= ammount)
      {
        return true;
      }
      else return false;
    }
  }
}
