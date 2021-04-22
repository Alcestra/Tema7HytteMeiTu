using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public AudioClip Theme;
    public AudioClip Ambiance;
    public string sndPlayer;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        BegoneSound();

    }

    void BegoneSound()
    {

        if(GameObject.FindGameObjectsWithTag("SndPlayer").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("SndPlayer"));
        }
            
    }

}
