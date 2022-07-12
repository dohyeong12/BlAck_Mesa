using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Tutorial_F;
    public GameObject TutoText_F;
    public GameObject START_F;
    public GameObject PASS_F;
    public GameObject FAIL_F;
    public GameObject End_F;
    public GameObject EndText_F;
    public GameObject GOOD_F;
    public GameObject CLEAR_F;
    public GameObject DEFEART_F;

    int b = 0; int c = 0;
    public Text Text_score;
    public int score;
    public static GameManager instance;

    bool Standby = true;

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
        PASS_F.SetActive(false);
        FAIL_F.SetActive(false);
        CLEAR_F.SetActive(false);
        GOOD_F.SetActive(false);
        DEFEART_F.SetActive(false);
        START_F.SetActive(false);
        End_F.SetActive(false);
        EndText_F.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && b == 0)
        {
            StartCoroutine(start());
            Tutorial_F.SetActive(false);
            TutoText_F.SetActive(false);
            b++;
        }
        Text_score.text = " " + Mathf.Round(score);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tutorial_F.SetActive(false);
        }
        if (c == 1) End_F.SetActive(true);

        if (score >= 10)
        {
            c = 1;
            GOOD_F.SetActive(true);
            EndText_F.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A))
            {
                TimeManager_F.instance.Time_F = 0;
                c = 0;
                
            }
            if (TimeManager_F.instance.Time_F <= 0)
            {
                EndText_F.SetActive(false);
                End_F.SetActive(false);
                CLEAR_F.SetActive(true);
                Flag_F.instance.r = 2;
                Flag_F.instance.pass = 2;
                Blue.instance.a = 1;
                Red.instance.a = 1;
                TimeManager_F.instance.Time_F += Time.deltaTime;
            }
        }
        else if (TimeManager_F.instance.Time_F <= 0)
        {
            DEFEART_F.SetActive(true);
            Flag_F.instance.r = 2;
            Flag_F.instance.pass = 2;
            Blue.instance.a = 2;
            Red.instance.a = 2;
            TimeManager_F.instance.Time_F += Time.deltaTime;
        }
    }
    IEnumerator start()
    {
        START_F.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        START_F.SetActive(false);
    }
}