using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flag : MonoBehaviour
{
    public GameObject BlueFlagImage;
    public GameObject RedFlagImage;

    public int r;
    public int pass;

    bool Standby = true;

    public static Flag instance;
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
        pass = 3;
        r = Random.Range(0, 2);
        StartCoroutine(s());
    }

    // Update is called once per frame
    void Update()
    {
        if (r == 0)
        {
            
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Standby == false )
            {
                GameManager.instance.score++;
                StartCoroutine(Pass());
                r = Random.Range(0, 2);

            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && Standby == false )
            {
                StartCoroutine(Fail());
            }
        }
        else if (r == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && Standby == false )
            {
                GameManager.instance.score++;
                StartCoroutine(Pass());
                r = Random.Range(0, 2);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && Standby == false )
            {
                StartCoroutine(Fail());
                r = Random.Range(0, 2);
            }
        }
    }
    IEnumerator Pass()
    {
        pass = 0;
        Standby = true;
        GameManager.instance.PASS.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        pass = 3;
        GameManager.instance.PASS.SetActive(false);
        Standby = false;
    }
    IEnumerator Fail()
    {
        pass = 1;
        Standby = true;
        GameManager.instance.FAIL.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        pass = 3;
        GameManager.instance.FAIL.SetActive(false);
        Standby = false;
    }
    IEnumerator s()
    {
        yield return new WaitForSeconds(1.5f);
        Standby = false;
    }
}
