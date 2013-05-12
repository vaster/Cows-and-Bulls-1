﻿//-----------------------------------------------------------------------
// <copyright file="BullsAndCows.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace BullsAndCows
{
    using System;

    /// <summary>
    /// Provides the entry point for the game
    /// </summary>
    public class BullsAndCows
    {
        /// <summary>
        /// The entry method for the game
        /// </summary>
        private static void Main()
        {
            Engine engine = new Engine();
            engine.Play();
        }
    }
}
