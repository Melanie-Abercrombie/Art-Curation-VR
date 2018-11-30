using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;
using System;

public class PlayerManager : MonoBehaviour {

    public GameObject _Inventory;  //reference object to be rotated
    public GameObject _LHand;
    Vector2 thumbstick;

    List<GameObject> sculptures;
   void Start()
    {
        PopulateInventory();
    }


    void Update()
    {

       if(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick) != Vector2.zero)
        {
            _Inventory.GetComponent<MeshRenderer>().enabled = true;
            thumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            RotateInventory(thumbstick.y);
        }
        thumbstick = Vector2.zero;

    }


    void PopulateInventory()
    {
        sculptures = GetComponent<MenuManager>().Sculptures;
        for (int i = 0; i < sculptures.Count; i++)
        {
           //populate 
        }
    }



    Vector3 z;
    void RotateInventory(float inertiaApplied)
    {
        z.z = inertiaApplied;
        _Inventory.GetComponent<Rigidbody>().AddTorque(z);
    }

    
   // enum slot { One, Two, Three, Four, Five, Six};


    

}
