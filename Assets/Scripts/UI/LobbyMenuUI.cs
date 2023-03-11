using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyMenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] playerNameTexts = new TextMeshProUGUI[4];

    private void OnEnable()
    {
        Player.ClientOnInfoUpdated += ClientHandleInfoUpdated;
    }

    private void OnDisable()
    {
        Player.ClientOnInfoUpdated -= ClientHandleInfoUpdated;
    }

    void ClientHandleInfoUpdated()
    {
        List<Player> Players = ((CustomNetworkManager)NetworkManager.singleton).Players;

        for (int i = 0; i < Players.Count; i++)
        {
            playerNameTexts[i].text = Players[i].GetDisplayName();
        }

        for (int i = 0; i < Players.Count; i++)
        {
            playerNameTexts[i].text = "Waiting for player...";
        }
    }
}
