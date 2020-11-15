using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class opendoor:MonoBehaviour
{



    public Transform door;

    void OnTriggerStay2D(Collider2D coll)

    {

        if (coll.gameObject.tag == "Player")

        {

            door.GetComponent<Animation>().Play("opendoorAni");

        }

    }
    /*void OnTriggerExit2D(Collider2D coll)

    {

        if (coll.gameObject.tag == "Player")

        {

            door.GetComponent<Animation>().Play("closedoorAni");

        }

    }*/

}

