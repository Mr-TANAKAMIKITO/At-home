using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float mPlayerMotionUp=0.5f;
    float mPlayerMotionDown=-0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, mPlayerMotionUp);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, mPlayerMotionDown);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(mPlayerMotionUp, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(mPlayerMotionDown, 0, 0);
        }
        if (Input.GetButtonDown("Jump"))
        {
            transform.position += new Vector3(0,2.0f,  0);
        }
    }
}
