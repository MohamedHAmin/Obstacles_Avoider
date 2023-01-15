using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public float z;
    public CharacterController controller;
    float speed = 5f;
    float time = 0;
    

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 2 &&  time > 1)
            z = -1;
        else if(time < 1)
            z = 1;
        else if ( time >= 2)
            time = 0;
        Vector3 move = transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
    }
}
