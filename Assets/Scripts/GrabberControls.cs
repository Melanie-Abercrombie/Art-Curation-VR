using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("Trigger pulled");
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
