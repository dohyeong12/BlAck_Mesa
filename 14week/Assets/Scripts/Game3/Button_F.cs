using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_F : MonoBehaviour
{

    public GameObject LBImage;
    public GameObject RBImage;
    public GameObject DLBImage;
    public GameObject DRBImage;



    // Start is called before the first frame update
    void Start()
    {
        DLBImage.SetActive(false);
        DRBImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(PushLButton());
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(PushRButton());
        }
    }
    IEnumerator PushLButton()
    {
        DLBImage.SetActive(true);
        LBImage.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        DLBImage.SetActive(false);
        LBImage.SetActive(true);
    }
    IEnumerator PushRButton()
    {
        DRBImage.SetActive(true);
        RBImage.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        DRBImage.SetActive(false);
        RBImage.SetActive(true);
    }
}
