using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    public float limitTime;

    public Text textTimer;
    int min;
    float sec;

    // Update is called once per frame
    
    void Update()
    {
        
        limitTime -= Time.deltaTime;
        
        
        if (limitTime >= 60f)
        {
            min = (int)limitTime / 60;
            sec = limitTime % 60;
            textTimer.text = min + " : " + (int)sec;
        }
        if (limitTime < 60f)
        {
            textTimer.text = "<color=black>" + (int)limitTime + "</color>";
        }
        if (limitTime < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

}
    
}
