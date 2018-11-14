using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit surfaceDetect;
        /*if (Physics.Raycast(transform.position ))
        {

        }*/
        //Layermask floor art vs. wall art
       
    }

    //Attaches an artwork to its appropriate surface when close
    public void SurfaceSnap(Collider col)
    {
        if (col.CompareTag("WallArt"))
        {
            Debug.Log("Wall art");
            Debug.Log(col.name);
            //Sets artwork orientation to match the surface
           // transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
        }

        if (col.CompareTag("FloorArt"))
        {
            Debug.Log("Floor art");
            Debug.Log(col.name);
            //Sets artwork orientation to match the surface
            //`transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }

        //Physics raycast small distance - get normal of what is hit - determines forward-facing vector
    }
}
