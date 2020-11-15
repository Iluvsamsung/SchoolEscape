using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stud_movement : MonoBehaviour
{
    const float speed = 20;
    public GameObject mainChar;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

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
        if (!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow)))
        {
            ani.SetBool("isRunning", false);
        }else
        {
            ani.SetBool("isRunning", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //1층 중앙 (-22, 60) 1층 왼쪽 (-184, 52) 1층 오른쪽 (140, 52)
        //2층 중앙 (-20, -256) 2층 왼쪽 (-180, -260) 2층 오른쪽 (230, -260)
        Debug.Log("충돌");
        if (coll.gameObject.tag == "StairMain1")
        {
            Debug.Log("stairmain1");
            transform.position = new Vector3(0, -180, 0);
        }
        if (coll.gameObject.tag == "StairMain2")
        {
            Debug.Log("stairmain2");
            transform.position = new Vector3(0, -6, 0);
        }
        if (coll.gameObject.tag == "StairL1")
        {
            Debug.Log("stairL1");
            transform.position = new Vector3(-90, -180, 0);
        }
        if (coll.gameObject.tag == "StairL2")
        {
            Debug.Log("stairL2");
            transform.position = new Vector3(-90, -6, 0);
        }
        if (coll.gameObject.tag == "StairR1")
        {
            Debug.Log("stairR1");
            transform.position = new Vector3(145, -180, 0);
        }
        if (coll.gameObject.tag == "StairR2")
        {
            Debug.Log("stairR2");
            transform.position = new Vector3(96, -6, 0);
        }
    }
}