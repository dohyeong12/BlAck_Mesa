using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager_F : MonoBehaviour
{
    public float Time_F = 30.5f;
    public Text Text_Timer;

    bool Standby = true;
    public static TimeManager_F instance;

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
        Text_Timer.text = " " + Mathf.Round(Time_F);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Standby = false;
        }
        if (Standby == false)
        {
            Time_F -= Time.deltaTime;
            Text_Timer.text = " " + Mathf.Round(Time_F);
        }
    }
}

