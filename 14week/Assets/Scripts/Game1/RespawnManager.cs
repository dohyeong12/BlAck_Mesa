using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public static RespawnManager instance;
    public List<GameObject> MobPool = new List<GameObject>();
    public GameObject[] Mobs;
    public int objCnt = 1;
    public int objtime = 0;
    void Awake()
    {
        for (int i = 0; i < Mobs.Length; i++)
        {
            for (int q = 0; q < objCnt; q++)
            {
                MobPool.Add(CreateObj(Mobs[i], transform));
            }
        }
    }
    private void Start()
    {
        GameManager2.instance.onPlay += PlayGame;
    }
    void PlayGame(bool isplay)
    {
        if (isplay)
        {
            for (int i = 0; i < MobPool.Count; i++)
            {
                if (MobPool[i].activeSelf)
                    MobPool[i].SetActive(false);
            }

            StartCoroutine(CreateMob());
        }
        else
            StopAllCoroutines();
    }
    IEnumerator CreateMob()
    {
        yield return new WaitForSeconds(1f);

        while (GameManager2.instance.isPlay)
        {
            MobPool[DeactiveMob()].SetActive(true);
            yield return new WaitForSeconds(Random.Range(0.7f, 0.35f));
        }
    }

    int DeactiveMob()
    {
        List<int> num = new List<int>();
        for (int i = 0; i < MobPool.Count; i++)
        {
            if (!MobPool[i].activeSelf)
                num.Add(i);
        }
        int x = 0;
        if (num.Count > 0)
            x = num[Random.Range(0, num.Count)];
        return x;
    }

    GameObject CreateObj(GameObject obj, Transform parent)
    {
        GameObject copy = Instantiate(obj);
        copy.transform.SetParent(parent);
        copy.SetActive(false);
        return copy;
    }
    private void Update()
    {
        if(285==GameManager2.instance.score)
        {
            StopAllCoroutines();
        }
    }
}
