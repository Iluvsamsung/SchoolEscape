using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stud_movement : MonoBehaviour
{
    const float speed = 5;
    public GameObject mainChar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up * speed, Time.deltaTime * 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left * speed, Time.deltaTime * 1f);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down * speed, Time.deltaTime * 1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right * speed, Time.deltaTime * 1f);
            transform.eulerAngles = Vector3.zero;
        }
    }
}
