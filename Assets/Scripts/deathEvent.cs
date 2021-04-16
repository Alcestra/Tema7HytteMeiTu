using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathEvent : MonoBehaviour
{
    private float timer;
    public float playerIsDead;
    public string sceneName;

    // Start is called before the first frame update
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > playerIsDead)
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("haha bear go burp");

        }
        
    }


}
