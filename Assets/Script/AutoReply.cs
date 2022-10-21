using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoReply : MonoBehaviour
{
   float timer = 0;


 // Use this for initialization
 void Start()
{
        if (EnemyController.EnemyKilled == 3)
    {
        
    }
 }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
 if (timer > 5)
 {
 Data.score = 0;
 EnemyController.EnemyKilled = 0;
 SceneManager.LoadScene("SampleScene");
}
    }
}
