using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stud_movement : MonoBehaviour
{
    const float speed = 20;
    public GameObject mainChar;
    Animator ani;
    public enum Places
    {
        복도_1층,
        도서관,
        보건실,
        행정실,
        교장실,
        발간실,
        복도_2층,
        교실_1학년1반,
        교실_1학년2반,
        교실_1학년3반,
        교실_1학년4반,
        교실_1학년5반,
        교실_1학년6반,
        교실_1학년7반,
        교무실
    };
    public Places InPlace;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        InPlace = Places.도서관;
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
        Debug.Log(coll.gameObject.name);
        if(coll.gameObject.tag == "stair")
        {
            if (coll.gameObject.name == "StairMain1")
            {
                Debug.Log("stairmain1");
                transform.position = new Vector3(-20, -256, 1);
            }
            if (coll.gameObject.name == "StairMain2")
            {
                Debug.Log("stairmain2");
                transform.position = new Vector3(-22, 60, 1);
            }
            if (coll.gameObject.name == "StairL1")
            {
                Debug.Log("stairL1");
                transform.position = new Vector3(-180, -260, 1);
            }
            if (coll.gameObject.name == "StairL2")
            {
                Debug.Log("stairL2");
                transform.position = new Vector3(-184, 52, 1);
            }
            if (coll.gameObject.name == "StairR1")
            {
                Debug.Log("stairR1");
                transform.position = new Vector3(230, -260, 1);
            }
            if (coll.gameObject.name == "StairR2")
            {
                Debug.Log("stairR2");
                transform.position = new Vector3(140, 52, 0);
            }
            if(InPlace == Places.복도_1층)
            {
                InPlace = Places.복도_2층;
            }else
            {
                InPlace = Places.복도_1층;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.tag == "placeChange")
        {
            if(coll.name == "library")
            {
                if (transform.position.y > coll.transform.position.y)
                {
                    InPlace = Places.복도_1층;
                }
                else InPlace = Places.도서관;
            }
            if(coll.name == "health")
            {
                if (transform.position.y > coll.transform.position.y)
                {
                    InPlace = Places.복도_1층;
                }
                else InPlace = Places.보건실;
            }
            if(coll.name == "publishing")
            {
                if (transform.position.y < coll.transform.position.y)
                {
                    InPlace = Places.복도_1층;
                }
                else InPlace = Places.발간실;
            }
            if (coll.name == "administration")
            {
                if (transform.position.y > coll.transform.position.y)
                {
                    InPlace = Places.복도_1층;
                }
                else InPlace = Places.행정실;
            }
            if (coll.name == "principal")
            {
                if (transform.position.x < coll.transform.position.x)
                {
                    InPlace = Places.행정실;
                }
                else InPlace = Places.교장실;
            }
        }
    }
}