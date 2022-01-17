﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace IntrepidProducts.ElevatorSystem.Buttons
{
    public class ElevatorFloorRequestPanel : AbstractPanel
    {
        public ElevatorFloorRequestPanel(params int[] floorNbrs)
        {
            ValidateFloorArguments(floorNbrs);

            foreach (var nbr in floorNbrs)
            {
                Add(new ElevatorFloorRequestButton(nbr));
            }
        }

        private void ValidateFloorArguments(params int[] floorNbrs)
        {
            if (floorNbrs.Length < 2)
            {
                throw new ArgumentException
                    ("Floor Request Panel must have at least two floors");
            }

            if (floorNbrs.Min() < 1)
            {
                throw new ArgumentException
                    ("Floor numbers must be positive");
            }

            if (floorNbrs.Distinct().Count() != floorNbrs.Length)
            {
                throw new ArgumentException
                    ("Floor numbers must be unique");
            }
        }
    }
}