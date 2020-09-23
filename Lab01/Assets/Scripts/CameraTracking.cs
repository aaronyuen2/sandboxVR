using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform target;
    bool follow = true;

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            //transform.LookAt(target);
            transform.position = new Vector3(
                target.position.x,
                target.position.y + 2,
                target.position.z - 10);

            Camera.main.transform.rotation = target.transform.rotation;
        }     
        // lose camera
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position;
            follow = false;
        }
    }
}
