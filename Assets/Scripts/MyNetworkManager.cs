using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        SyncAttributes syncAttributes = conn.identity.GetComponent<SyncAttributes>();
        syncAttributes.SetPlayerColor(RandomColor());
        syncAttributes.SetPlayerType("Online player");
    }

    Color RandomColor()
    {
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);

        return new Color(r, g, b);
    }
}
