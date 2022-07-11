using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    #region instance
    public static GameManager2 instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnPlay(bool isPlay);
    public OnPlay onPlay;

    public float psecondSpeed = 0;
    public float gameSpeed = 1;
    public bool isPlay = false;
    public GameObject GameOverTxt;
    public GameObject ClearTxt;
    public GameObject playBtn;

    public Text bestscoreTxt;
    public Text scoreTxt;
    public int score = 0;
    IEnumerator AddScore()
    {
        while (isPlay)
        {
            score++;
            scoreTxt.text = score.ToString();
            gameSpeed = gameSpeed + psecondSpeed;
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void PlayBtnClick()
    {
        playBtn.SetActive(false);
        isPlay = true;
        onPlay.Invoke(isPlay);
        score = 0;
        GameOverTxt.SetActive(false);
        ClearTxt.SetActive(false);
        scoreTxt.text = score.ToString();
        StartCoroutine(AddScore());
        gameSpeed = 10;
    }

    public void GameOver()
    {
        isPlay = false;
        onPlay.Invoke(isPlay);
        StopCoroutine(AddScore());
        GameOverTxt.SetActive(true);
        HPLC.instance.LoseGame = 1;
        SceneManager.LoadScene("INgame");
    }
    void Update()
    {
        if (300 == score)
        {
            isPlay = false;
            onPlay.Invoke(isPlay);
            StopCoroutine(AddScore());
            ClearTxt.SetActive(true);
            HPLC.instance.WinGame = 1;
            SceneManager.LoadScene("INgame");
        }
    }
}
