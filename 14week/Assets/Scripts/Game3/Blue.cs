using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{

    public GameObject Right_F;
    public GameObject RArrow_F;

    public int a = 0;
    int b = 0;
    [SerializeField] bool Standby = true;

    public static Blue instance;
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
        Right_F.SetActive(false);
        RArrow_F.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //X를 누르면 0.5초후 r의 값에 따라 파란깃발이 올라감
        if (Input.GetKey(KeyCode.X) && b == 0)
        {
            StartCoroutine(BlueStart());
            b++;
        }

        //플레이어의 선택 후 새롭게 초기화된 r의 값이 1이 될 경우 파란깃발이 올라가고 텍스트가 보여짐
        if (Flag_F.instance.r == 1 && Standby == false)
        {
            Right_F.SetActive(true);
            RArrow_F.SetActive(true);
            transform.rotation = Quaternion.Euler(0, 0, 1);
        }

        //플레이어의 선택으로 파란깃발이 내려가고 텍스트가 사라지다 그리고 Flag의 pass를 3으로 초기화
        //플레이어가 올바른 선택을 했을 경우 pass=0 그러지 않을 경우 pass=1 (Flag에서 초기화됨)
        if (Flag_F.instance.pass == 0 && Standby == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 110);
            Right_F.SetActive(false);
            RArrow_F.SetActive(false);

            StartCoroutine(BluePass2());
            StartCoroutine(BluePass());
        }
        else if (Flag_F.instance.pass == 1 && Standby == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 110);
            Right_F.SetActive(false);
            RArrow_F.SetActive(false);

            StartCoroutine(BluePass2());
            StartCoroutine(BlueFail());
        }

        //시간이 0이하가 되면 파란깃발이 올라감
        if (a == 1)
        {
            Standby = true;
            transform.rotation = Quaternion.Euler(0, 0, 1);
            Right_F.SetActive(false);
            RArrow_F.SetActive(false);
        }
        else if (a == 2)
        {
            Standby = true;
            transform.rotation = Quaternion.Euler(0, 0, 110);
            Right_F.SetActive(false);
            RArrow_F.SetActive(false);
        }
    }
    IEnumerator BlueStart()
    {
        yield return new WaitForSeconds(0.5f);
        Standby = false;
    }
    // 플레이어가 옭바른 선택을 했을 때 0.2초 만큼 기다린다.
    IEnumerator BluePass()
    {
        Standby = true;
        yield return new WaitForSeconds(0.2f);
        Standby = false;
    }
    // 플레이어가 틀린 선택을 했을 때 1초 만큼 기다린다.
    IEnumerator BlueFail()
    {
        Standby = true;
        yield return new WaitForSeconds(1);
        Standby = false;
    }
    IEnumerator BluePass2()
    {
        yield return new WaitForSeconds(0.1f);
        Flag_F.instance.pass = 2;
    }
}