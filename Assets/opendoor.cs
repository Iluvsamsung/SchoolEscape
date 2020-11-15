using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class opendoor : MonoBehaviour
{



    public Transform door;

    void OnTriggerEnter(Collider coll)

    {

        if (coll.gameObject.tag == "student")

        {

            door.GetComponent<Animation>().Play("openthedoor");

        }

    }

}

