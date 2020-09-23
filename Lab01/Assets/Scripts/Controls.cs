using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // detect if keyboard has pressed any key?
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.4f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.4f;
        }

        //up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += 0.4f;
        }

        // down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= 0.4f;
        }

        // rotate left
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, 1);
        }

        // rotate right
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -1);
        }

        


        this.transform.position = pos;
    }
}
