using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;
    public Transform spawn;

    void Start()
    {
        // NO LLAMAR JoinRoom acá
        // NO LLAMAR OnJoinedRoom acá

        // Si ya estoy conectado desde el menú → entrar a un room
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(null);
    }

    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate(
            playerPrefab.name,
            spawn.position,
            spawn.rotation
        );

        player.GetComponent<PhotonView>().RPC(
            "SetNameText",
            RpcTarget.AllBuffered,
            PlayerPrefs.GetString("PlayerName")
        );
    }
}
