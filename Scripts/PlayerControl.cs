using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;
    float speed = 6f;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = -1;
        float z = Input.GetAxis("Horizontal");

        time += Time.deltaTime;
        if (time >= 2)
        {
            speed *= 1.2f;
            time = 0;
        }
        Vector3 move = transform.right * x +  transform.forward * z; 
        
        controller.Move(move * speed * Time.deltaTime);
    }
}
