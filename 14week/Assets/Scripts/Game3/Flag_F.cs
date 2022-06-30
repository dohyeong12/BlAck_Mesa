using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flag_F : MonoBehaviour
{
    public GameObject BlueFlagImage;
    public GameObject RedFlagImage;

    public int r = 2;
    public int pass = 2;

    bool flagstart = false;
    bool Standby = true; 

    public static Flag_F instance;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && flagstart == false)
        {
            flagstart = true;
            Standby = false;
            r = Random.Range(0, 2);
        }

        if (r == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Standby == false)
            {
                r = Random.Range(0, 2);
                GameManager.instance.score++;
                pass = 0;
                StartCoroutine(Pass());
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && Standby == false)
            {
                r = Random.Range(0, 2);
                pass = 1;
                StartCoroutine(Fail());
            }
        }
        else if (r == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && Standby == false)
            {
                r = Random.Range(0, 2);
                GameManager.instance.score++;
                pass = 0;
                StartCoroutine(Pass());
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && Standby == false)
            {
                r = Random.Range(0, 2);
                pass = 1;
                StartCoroutine(Fail());
            }
        }

    }
    IEnumerator Pass()
    {
        Standby = true;
        GameManager.instance.PASS_F.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        GameManager.instance.PASS_F.SetActive(false);
        Standby = false;
    }
    IEnumerator Fail()
    {
        Standby = true;
        GameManager.instance.FAIL_F.SetActive(true);
        yield return new WaitForSeconds(1);
        GameManager.instance.FAIL_F.SetActive(false);
        Standby = false;
    }
}
