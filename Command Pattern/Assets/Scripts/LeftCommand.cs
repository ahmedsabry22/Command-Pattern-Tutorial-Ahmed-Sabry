using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LeftCommand : ICommand
{
    public string Name => "Left";

    public void ExectueCommand (Player player)
    {
        player.MoveLeft ();
    }
}