using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CommandController : MonoBehaviour
{
    public static CommandController Instance;

    private List<ICommand> MovementCommands = new List<ICommand> ();

    private void Awake ()
    {
        if (Instance == null)
            Instance = this;

        MovementCommands.Add (new ForwardCommand ());
        MovementCommands.Add (new BackwardCommand ());
        MovementCommands.Add (new RightCommand ());
        MovementCommands.Add (new LeftCommand ());
        MovementCommands.Add (new StopCommand ());
    }

    public void ExecuteCommand (string commandName)
    {
        ICommand targetCommand = MovementCommands.Find (c => c.Name == commandName);

        targetCommand.ExectueCommand (PlayerSelectionManager.Instance.currentSelectedPlayer);
    }
}