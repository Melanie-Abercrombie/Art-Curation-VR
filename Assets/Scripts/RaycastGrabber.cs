using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGrabber : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        float distance;

        //Debug Raycast in the Editor
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 50;
        Debug.DrawRay(transform.position, forward, Color.cyan);

        if(Physics.Raycast(transform.position, (forward), out hit)){
            distance = hit.distance;   //how far away the hit object is
            print (distance + "m away, hit " + hit.collider.gameObject.name);
        }
    }
}
