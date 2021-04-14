using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public GameObject birbs;

    private void Awake()
    {
        DontDestroyOnLoad(birbs);
    }
}
