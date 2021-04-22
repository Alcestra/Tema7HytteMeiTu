using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTalking : MonoBehaviour
{
    public string Talking;

    public void OnGUI()
    {
        Talking = GUI.TextArea(new Rect(400,400,200,100),Talking, 200);
    }
}
