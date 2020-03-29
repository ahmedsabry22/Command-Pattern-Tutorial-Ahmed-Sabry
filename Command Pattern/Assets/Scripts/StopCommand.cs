using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StopCommand : ICommand
{
    public string Name => "Stop";

    public void ExectueCommand (Player player)
    {
        player.Stop ();
    }
}