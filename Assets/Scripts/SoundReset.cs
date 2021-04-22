using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundReset : MonoBehaviour
{

    public string SND;

    private void Awake()
    {
        Destroy(GameObject.Find(SND));
    }
}
