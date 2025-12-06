using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NombreJugador : MonoBehaviourPunCallbacks
{
    public TMP_Text PlayerName;

    [PunRPC]
    public void SetNameText(string name)
    {
        PlayerName.text = name; 
    }
}
    