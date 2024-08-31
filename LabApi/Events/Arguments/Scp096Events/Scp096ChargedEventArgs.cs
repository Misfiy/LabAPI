﻿using LabApi.Events.Arguments.Interfaces;
using LabApi.Features.Wrappers;
using System;
namespace LabApi.Events.Arguments.Scp096Events;

/// <summary>
/// Represents the arguments for the <see cref="Handlers.Scp096Events.Charged"/> event.
/// </summary>
public class Scp096ChargedEventArgs : EventArgs, IPlayerEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Scp096ChargedEventArgs"/> class.
    /// </summary>
    /// <param name="player">The SCP-096 player instance.</param>
    public Scp096ChargedEventArgs(Player player)
    {
        Player = player;
    }

    /// <summary>
    /// The SCP-096 player instance.
    /// </summary>
    public Player Player { get; }
}
