using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public List<sound> sounds = new List<sound>();

    private void Awake()
    {
        DontDestroyOnLoad(sounds);
    }
}
