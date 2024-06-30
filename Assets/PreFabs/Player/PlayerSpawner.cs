
using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject playerPrefab;

    public void PlayerJoined(PlayerRef player)
{
    if (player == Runner.LocalPlayer)
    {
        Runner.Spawn(playerPrefab, new Vector3(1, 1, 0), Quaternion.identity);
    }
}
}