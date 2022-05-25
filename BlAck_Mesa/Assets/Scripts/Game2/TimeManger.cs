using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManger : MonoBehaviour
{
    public float LimitTime = 31.5f;
    public Text Text_Timer;

    public static TimeManger instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            return;
        }
        else if (instance != null)
        {

            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        Text_Timer.text = " " + Mathf.Round(LimitTime);
       
    }
}
