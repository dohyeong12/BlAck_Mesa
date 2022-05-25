using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketController : MonoBehaviour
{

    public GameObject Win;
    int speed = 10; //���ǵ�
    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
        Invoke("GameStop", 20f); // ���� 20�� ����
        Invoke("TimeLimit", 19.5f); // ���� �̸� �Ͻ�����
    }

    void GameStop()
    {
        Win.SetActive(true); //�¸� �޽��� ���

        Time.timeScale = 0;

        HPLC.instance.PlayGame = 1;
        HPLC.instance.WinGame = 1;
        SceneManager.LoadScene("INgame");
    }






    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x������ �̵��� ��
        this.transform.Translate(new Vector3(xMove, 0));  //�̵�
    }
}
