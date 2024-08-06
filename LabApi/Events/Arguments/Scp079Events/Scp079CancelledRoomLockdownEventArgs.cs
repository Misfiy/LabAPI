﻿using System;
using LabApi.Events.Arguments.Interfaces;
using LabApi.Features.Wrappers.Facility.Rooms;
using LabApi.Features.Wrappers.Player;

namespace LabApi.Events.Arguments.Scp079Events;

/// <summary>
/// Represents the arguments for the <see cref="Handlers.Scp079Events.CancelledRoomLockdown"/> event.
/// </summary>
public class Scp079CancelledRoomLockdownEventArgs : EventArgs, IPlayerEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Scp079CancelledRoomLockdownEventArgs"/> class.
    /// </summary>
    /// <param name="player">The SCP-079 player instance.</param>
    /// <param name="room">The affected room instance.</param>
    public Scp079CancelledRoomLockdownEventArgs(Player player, Room room)
    {
        Player = player;
        Room = room;
    }

    /// <summary>
    /// The SCP-079 player instance.
    /// </summary>
    public Player Player { get; }

    /// <summary>
    /// The affected room instance.
    /// </summary>
    public Room Room { get; }
}
