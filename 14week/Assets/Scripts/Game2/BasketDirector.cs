using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�
using UnityEngine.SceneManagement;

public class BasketDirector : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject lose;
    void Start()
    {
        lose.SetActive(false);
        this.hpGauge = GameObject.Find("hpGauge");

    }

    public void DecreaseHp()
    {
        // Debug.Log("����!");
        // lose.SetActive(true);
        Time.timeScale = 0;
        HPLC.instance.PlayGame = 1;
        HPLC.instance.LoseGame = 1;
        SceneManager.LoadScene("INgame");
    }




}
