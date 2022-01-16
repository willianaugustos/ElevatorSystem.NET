﻿using System;
using IntrepidProducts.ElevatorSystem.Buttons;

namespace IntrepidProducts.ElevatorSystem.Tests.Buttons
{
    public class TestButton : AbstractButton
    {
        public Guid Id = new Guid();
    }

    public class TestPanel : AbstractPanel
    {
        public bool Add(params TestButton[] buttons)
        {
            // ReSharper disable once CoVariantArrayConversion
            return base.Add(buttons);
        }

    }
}