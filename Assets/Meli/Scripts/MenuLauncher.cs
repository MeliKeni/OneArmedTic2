using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class MenuLauncher : MonoBehaviourPunCallbacks
{
    public TMP_InputField InputField;
    public TMP_Text buttonText;
    
    public void OnClickConnect()
    {
        if (InputField.text.Length > 0)
        {
            PhotonNetwork.NickName = InputField.text;
            buttonText.text = "Conectando...";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Tuto2");
    }
}
