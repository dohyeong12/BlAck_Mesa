using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class escape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            HPLC.instance.Work = 0;
            HPLC.instance.Study = 0;
            HPLC.instance.Exercise = 0;
            SceneManager.LoadScene("INgame");
        }
    }
}