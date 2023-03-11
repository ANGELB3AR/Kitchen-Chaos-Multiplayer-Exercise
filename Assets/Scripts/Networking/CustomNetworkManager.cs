using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
    public List<Player> Players { get; private set; } = new List<Player>();

    Player player;

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        player.SetDisplayName($"Player {Players.Count}");
    }
}
