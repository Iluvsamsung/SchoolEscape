using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public GameObject target;
 
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, 0, -10);
    }
}
