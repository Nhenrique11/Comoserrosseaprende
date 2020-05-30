using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooki.cs : MonoBehaviour {
    bool mousenocookie;
    // Start is called before the first frame update
    void Start()
    {
    mousenocookie = false;  
    }

    // Update is called once per frame
    void Update()
    {
       if(mousenocookie == true){
        if (Input.GetMouseButtonDown(0)) {
          Getcomponent<>
        }
      }
    }

void OnMouseEnter() {
    mousenocookie = true;
}

    void OnMouseExit()
{
    mousenocookie = false;
}