using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerName;
    public void StartNew()
    {
        UserData.Instance.userName = SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public string SetPlayerName()
    {
        return playerName.text;
        
    }
}
