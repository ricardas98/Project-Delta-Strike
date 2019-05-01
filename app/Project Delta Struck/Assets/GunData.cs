﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[System.Serializable]
public class GunData
{
    public string Name;
    public int BulletsCount = 0;

    public GunData(string Name, int BulletsCount)
    {
        this.Name = Name;
        this.BulletsCount = BulletsCount;
    }
}