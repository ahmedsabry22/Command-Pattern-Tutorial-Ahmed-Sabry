using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class RightCommand : ICommand
{
    public string Name => "Right";

    public void ExectueCommand (Player player)
    {
        player.MoveRight ();
    }
}