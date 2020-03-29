using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ForwardCommand : ICommand
{
    public string Name => "Forward";

    public void ExectueCommand (Player player)
    {
        player.MoveForward ();
    }
}