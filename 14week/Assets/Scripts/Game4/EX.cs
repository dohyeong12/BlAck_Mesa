using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EX : MonoBehaviour
{
    public GameObject Image;
    public Text Explain;
    public GameObject Timer;
    
    // Update is called once per frame
    
    void Update()
    {
        Timer.SetActive(false);
        if (Input.anyKey)
        {
            Image.SetActive(false);
            Timer.SetActive(true);
            
        }   
    }
}
