using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerSelectionManager : MonoBehaviour
{
    public List<Player> PlayersInGame;

    public static PlayerSelectionManager Instance;
    public Player currentSelectedPlayer;

    private void Awake ()
    {
        if (Instance == null)
            Instance = this;
    }

    public void SelectPlayer (Player player)
    {
        foreach (var p in PlayersInGame)
        {
            p.activeIndicator.SetActive (false);
        }

        player.activeIndicator.SetActive (true);
        currentSelectedPlayer = player;
    }
}