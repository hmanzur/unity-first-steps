using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float x;

    // Update is called once per frame
    void Update()
    {

        // if (Input.GetKeyDown(KeyCode.LEFT) this.tranform.Translate(-X, 0, 0);
        // else if Input.GetKeyDown(KeyCode.RIGHT) this.tranform.Translate(-X, 0, 0);

        x = Input.GetAxis("Horizontal");

        //if (x)
        //{
        this.transform.Translate(x * 0.5f, 0, 0);
        //}
        
    }
}
