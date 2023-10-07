using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOfDeli : MonoBehaviour
{
    int score = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
        score++;
        Debug.Log("your score is" +  score);
        }

    }

}
