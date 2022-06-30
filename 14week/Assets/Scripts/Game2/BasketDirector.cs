using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가

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
        Debug.Log("닿음!");
        lose.SetActive(true);
        Time.timeScale = 0;
    }




}
