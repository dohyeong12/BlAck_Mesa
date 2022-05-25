using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    private int D, H, M, Time = 141120; // 날짜, 시간
    private int Gold = 0;               // 소지금
    private int Intelligence = 0;       // 지능
    private int Endurance = 100;        // 체력
    private int MAXEndurance = 100;     // 최대 체력

    public GameObject Work;     // 일 버튼
    public GameObject Study;    // 공부 버튼
    public GameObject Exercise; // 운동 버튼
    public GameObject Rest;     // 휴식 버튼
    public GameObject MAXEnduImage; // 체력이 이미 가득 찾습니다!!
    public GameObject MINEnduImage; // 체력이 없습니다!!

    public Text timeText;       // 시간을 나타내는 텍스트
    public Text GoldText;       // 소지금을 나타내는 텍스트
    public Text IntelligencText;// 지능을 나타내는 텍스트
    public Text EnduranceText;  // 체력을 나타내는 텍스트


    private void Start()
    {
        MAXEnduImage.SetActive(false);
        MINEnduImage.SetActive(false);
    }

    void Update()
    {
        D = Time / 1440;
        H = (Time - D * 1440) / 60;
        M = (Time - D * 1440) % 60;
        timeText.text = D + "일 " + H + "시 " + M + "분";
        GoldText.text = "소지금 : " + Gold + "원";
        IntelligencText.text = "지능 : " + Intelligence;
        EnduranceText.text = "체력 : " + Endurance + "/" + MAXEndurance;
        if(Time <= 0)
        {
            SceneManager.LoadScene("ending1");
        }
    }

    public void ClickWork()     // 일 버튼을 클릭했을때
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Gold += 100;
            Endurance -= 5;
            Time -= 300;
        }
    }
    public void ClickStudy()    // 공부 버튼을 클릭했을때
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Intelligence += 10;
            Endurance -= 5;
            Time -= 60;
        }
    }
    public void ClickExercise() // 운동 버튼을 클릭했을때
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Endurance -= 5;
            MAXEndurance += 10;
            Time -= 300;
        }
    }
    public void ClickRest()     // 휴식 버튼을 클릭했을때
    {
        if(Endurance >= MAXEndurance)
        {
            StartCoroutine(MAXEndu());
        }
        else
        {
            Endurance = MAXEndurance;
            Time -= 480;
        }
    }

    IEnumerator MAXEndu()       // 체력이 가득할 때
    {
        MAXEnduImage.SetActive(true);
        yield return new WaitForSeconds(2);
        MAXEnduImage.SetActive(false);
    }
    IEnumerator MINEndu()       // 체력이 없을 때
    {
        MINEnduImage.SetActive(true);
        yield return new WaitForSeconds(2);
        MINEnduImage.SetActive(false);
    }
}