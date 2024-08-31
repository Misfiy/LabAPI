﻿using LabApi.Events.Arguments.Interfaces;
using LabApi.Features.Wrappers;
using System;
namespace LabApi.Events.Arguments.Scp079Events;

/// <summary>
/// Represents the arguments for the <see cref="Handlers.Scp079Events.BlackingOutRoom"/> event.
/// </summary>
public class Scp079BlackingOutRoomEventsArgs : EventArgs, ICancellableEvent, IPlayerEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Scp079BlackingOutRoomEventsArgs"/> class.
    /// </summary>
    /// <param name="player">The SCP-079 player instance.</param>
    /// <param name="room">The affected room instance.</param>
    public Scp079BlackingOutRoomEventsArgs(Player player, Room room)
    {
        Player = player;
        Room = room;
        IsAllowed = true;
    }

    /// <summary>
    /// The SCP-079 player instance.
    /// </summary>
    public Player Player { get; }

    /// <summary>
    /// The affected room instance.
    /// </summary>
    public Room Room { get; }

    /// <inheritdoc />
    public bool IsAllowed { get; set; }
}
