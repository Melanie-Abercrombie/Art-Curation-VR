using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberControls : MonoBehaviour {

    private GameObject grabbedObject;
    private bool grabbing;
    public float grabRadius;

	void GrabObject()
    {
        grabbing = true;
        RaycastHit[] hits;

        //Sphere of interaction around hand
        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, artwork);

        //Collided
        if (hits.Length > 0)
        {
            //Grabs closest object
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < closestHit.distance){
                    closestHit = i;
                }
            }
            grabbedObject = hits[closestHit].transform.gameObject;

            grabbedObject.GetComponent<Rigidbody>.isKinematic = true;
            grabbedObject.transform.position = transform.position;
            //Follow hand
        }
    }

    void DropObject()
    {
        grabbing = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("Trigger pulled");
        }

        if(!grabbing && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) == 1)
        {
            GrabObject;
        }
        if(grabbing && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) < 1)
        {
            DropObject;
        }

        //Grab, point, press A - trigger raycast
        if(!grabbing && (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) == 1) && (OVRINPUT.GetDown(OVRInput.Button. )){

        }
	}

    void OnTriggerEnter(Collider col)
    {
        RaycastGrabber();
        //SurfaceSnap(col);
    }

    // Points a ray to select an object in the distance
    public void RaycastGrabber()
    {

        Debug.Log("Raycast engaged");
    }
}
