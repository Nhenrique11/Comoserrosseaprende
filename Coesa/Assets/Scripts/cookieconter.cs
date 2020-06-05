using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieconter : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        gamecontroller.instance.totalScore += score;
        gamecontroller.instance.UpdateScoreText();
    }
}
