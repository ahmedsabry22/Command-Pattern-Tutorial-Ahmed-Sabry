using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BackwardCommand : ICommand
{
    public string Name => "Backward";

    public void ExectueCommand (Player player)
    {
        player.MoveBack ();
    }
}