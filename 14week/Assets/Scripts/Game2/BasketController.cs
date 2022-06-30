using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    
    public GameObject Win;
    int speed = 10; //스피드
    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
        Invoke("GameStop", 30f); // 게임 30초 제한
        Invoke("TimeLimit", 28f); //눈송이 멈추기?
        
    }

    void GameStop()
    {
        Win.SetActive(true); //승리 메시지 띄움

        Time.timeScale = 0;
    }






    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x축으로 이동할 양
        this.transform.Translate(new Vector3(xMove, 0));  //이동
    }
}
