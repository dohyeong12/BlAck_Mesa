using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Invoke : MonoBehaviour
{

    void Start()
    {
        Invoke("Scen", 2f);
    }

    void Scen()
    {
        HPLC.instance.PlayGame = 1;
        HPLC.instance.WinGame = 1;
        SceneManager.LoadScene("INgame");
    }
}
