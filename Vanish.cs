using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vanish : MonoBehaviour
{
    int Score;
    public Text ScoreText;
    

    void Update()
    {
        ScoreText.text = Score.ToString();
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.name=="Player")
        {
            //Score = Score + 1;
            Destroy(gameObject);
            //SetScoreText();
            Score++;
        }
    }
    /*void SetScoreText()
    {
        //ScoreText.text = "Score:" +Score.ToString();
        ScoreAmount.text = Score.ToString("0");
        Score++;
    }*/
}
