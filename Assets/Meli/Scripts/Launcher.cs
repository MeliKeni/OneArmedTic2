using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks

{

    public PhotonView playerPrefab;
    public Transform spawn;

        void Start()
    {
        OnJoinedRoom();
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawn.position, spawn.rotation);
    }
}
