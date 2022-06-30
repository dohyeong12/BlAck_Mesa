using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPLC : MonoBehaviour
{
    public static HPLC instance = null;
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public int D, H, M;
    public int Time = 141120;
    public int Gold = -5000;
    public int Intelligence = 10;
    public int Endurance = 100;
    public int MAXEndurance = 100;
    public int Work = 0, Study = 0, Exercise = 0;
    public int WinGame = 0, LoseGame = 0;
    public int PlayGame = 0;

    public int CG = 0, CI = 0, CE = 0; 
}
