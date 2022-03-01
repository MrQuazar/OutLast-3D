using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
    public static int Score = 0;

    public float x = 0;
    public float y = 0;
    public float width = 10;
    public float height = 10;
    
  void OnGUI()
    {
       GUI.Label(new Rect(x, y, width, height),"Score:" +Score);
        
    }
}
