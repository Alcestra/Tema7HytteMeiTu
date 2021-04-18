using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public AudioClip Birbs;
    public AudioClip BG_Music;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
