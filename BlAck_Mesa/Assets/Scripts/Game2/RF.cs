using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RF : MonoBehaviour
{
    bool Standby = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StandR1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Flag.instance.r == 0 && Standby == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 1);
        }

       if(Flag.instance.pass == 0 && Standby == false){
            transform.rotation = Quaternion.Euler(0, 0, -110);
            StartCoroutine(StandR2());
        }
        else if (Flag.instance.pass == 1 && Standby == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, -110);
            StartCoroutine(StandR3());
        }
    }
    IEnumerator StandR1()
    {
        yield return new WaitForSeconds(1.5f);
        Standby = false;
    }
    IEnumerator StandR2()
    {
        Standby = true;
        yield return new WaitForSeconds(0.2f);
        Standby = false;

    }
    IEnumerator StandR3()
    {
        Standby = true;
        yield return new WaitForSeconds(1.5f);
        Standby = false;

    }
}
