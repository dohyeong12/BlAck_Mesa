using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   public GameObject PASS;
    public GameObject FAIL;
    public GameObject CLEAR;
    public GameObject START;
    public GameObject READY;

    public Text Text_Score;
    public int score;
    public static GameManager instance;

    public bool Standby = true;

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
    void Start()
    {
        PASS.SetActive(false);
        FAIL.SetActive(false);
        CLEAR.SetActive(false);
        START.SetActive(false);
        StartCoroutine(start());
    }

    // Update is called once per frame
    void Update()
    {
        Text_Score.text = " " + Mathf.Round(score);

        if (score >= 40)
        {
            StartCoroutine(Clear());
            
        }else if (TimeManger.instance.LimitTime <= 0)
        {
            FAIL.SetActive(true);
            HPLC.instance.PlayGame = 1;
            HPLC.instance.LoseGame = 1;
            SceneManager.LoadScene("INgame");
            //TimeManger.instance.LimitTime += Time.deltaTime;
        }


    }
    IEnumerator start()
    {
        yield return new WaitForSeconds(1);
        READY.SetActive(false);
        START.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        START.SetActive(false);
    }
    IEnumerator Clear()
    {
        yield return new WaitForSeconds(0.5f);
        CLEAR.SetActive(true);
        HPLC.instance.PlayGame = 1;
        HPLC.instance.WinGame = 1;
        SceneManager.LoadScene("INgame");
    }
}

