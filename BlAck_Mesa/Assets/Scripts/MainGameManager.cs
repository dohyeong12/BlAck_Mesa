using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    public int mEndu = 5;
    public int mmEndu = 10;
    public Text MAXEnduImage; // ü���� �̹� ���� ã���ϴ�!!
    public Text MINEnduImage; // ü���� �����ϴ�!!

    public Text timeText;       // �ð��� ��Ÿ���� �ؽ�Ʈ
    public Text GoldText;       // �������� ��Ÿ���� �ؽ�Ʈ
    public Text IntelligencText;// ������ ��Ÿ���� �ؽ�Ʈ
    public Text EnduranceText;  // ü���� ��Ÿ���� �ؽ�Ʈ



    enum Game                   // enum ����
    {
        Run = 1,
        BulletHell,
        BlueflagWhiteflag,
        OXQize,
    };


    private void Start()
    {
        MAXEnduImage.gameObject.SetActive(false);
        MINEnduImage.gameObject.SetActive(false);
    }
    void Update()
    {
        HPLC.instance.D = HPLC.instance.Time / 1440;
        HPLC.instance.H = (HPLC.instance.Time - HPLC.instance.D * 1440) / 60;
        HPLC.instance.M = (HPLC.instance.Time - HPLC.instance.D * 1440) % 60;
        timeText.text = HPLC.instance.D + "일 " + HPLC.instance.H + "시 " + HPLC.instance.M + "분";      // ���ܿ� ���� ���� ǥ��
        GoldText.text = "소지금 : " + HPLC.instance.Gold + "원";
        IntelligencText.text = "지능 : " + HPLC.instance.Intelligence;
        EnduranceText.text = "체력 : " + HPLC.instance.Endurance + "/" + HPLC.instance.MAXEndurance;

        if(HPLC.instance.Time <= 0)       // Time�� 0�� �Ǿ��� ��
        {
            SceneManager.LoadScene("ending1");
        }

        if(HPLC.instance.PlayGame == 1){
            GameEnd();
            HPLC.instance.PlayGame = 0;
        }
    }

    public void ClickWork()     // �� ��ư�� Ŭ��������
    {
        if ( HPLC.instance.Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            HPLC.instance.CG += 1;
            HPLC.instance.Work = 1;
            postGame();
        }
    }
    public void ClickStudy()    // ���� ��ư�� Ŭ��������
    {
        if ( HPLC.instance.Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            HPLC.instance.CI += 1;
            HPLC.instance.Study = 1;
            postGame();
        }
    }
    public void ClickExercise() // � ��ư�� Ŭ��������
    {
        if ( HPLC.instance.Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            HPLC.instance.CE += 1;
            HPLC.instance.Exercise = 1;
            postGame();
        }
    }
    public void ClickRest()     // �޽� ��ư�� Ŭ��������
    {
        if(HPLC.instance.Endurance >= HPLC.instance.MAXEndurance)
        {
            StartCoroutine(MAXEndu());
        }
        else
        {
            HPLC.instance.Endurance = HPLC.instance.MAXEndurance;
            HPLC.instance.Time -= 480;
        }   
    }

    IEnumerator MAXEndu()       // ü���� ������ ��
    {
        MAXEnduImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        MAXEnduImage.gameObject.SetActive(false);
    }
    IEnumerator MINEndu()       // ü���� ���� ��
    {
        MINEnduImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        MINEnduImage.gameObject.SetActive(false);
    }

    public void postGame()      // �̴ϰ��� �����Ű��
    {
        switch (Random.Range(1, 5))
        {
            case (int)Game.OXQize:
                SceneManager.LoadScene("Game1");
                break;
            case (int)Game.Run:
                SceneManager.LoadScene("Game2");
                break;
            case (int)Game.BlueflagWhiteflag:
                SceneManager.LoadScene("Game3");
                break;
            case (int)Game.BulletHell:
                SceneManager.LoadScene("Game4");
                break;
        }
    }

    public void GameEnd(){
        if (HPLC.instance.WinGame == 1)
        {
            if(HPLC.instance.Work == 1){
                HPLC.instance.Gold += HPLC.instance.Intelligence * 10;
                HPLC.instance.Endurance -= mEndu;
            }else if(HPLC.instance.Study == 1){
                HPLC.instance.Intelligence += 10;
                HPLC.instance.Endurance -= mEndu;
            }else if(HPLC.instance.Exercise  == 1){ 
                HPLC.instance.MAXEndurance += 10;
                HPLC.instance.Endurance -= mEndu;
            }
        }
        else if (HPLC.instance.LoseGame == 1)
        {
            if(HPLC.instance.Work == 1){
                HPLC.instance.Gold += HPLC.instance.Intelligence * 5;
                HPLC.instance.Endurance -= mmEndu;
            }else if(HPLC.instance.Study == 1){
                HPLC.instance.Intelligence += 5;
                HPLC.instance.Endurance -= mmEndu;
            }else if(HPLC.instance.Exercise  == 1){ 
                HPLC.instance.MAXEndurance += 5;
                HPLC.instance.Endurance -= mmEndu;
            } 
        }
        HPLC.instance.Time -= 360;
        HPLC.instance.WinGame = 0;
        HPLC.instance.LoseGame = 0;
        HPLC.instance.Work = 0;
        HPLC.instance.Study = 0;
        HPLC.instance.Exercise = 0;
    }
}