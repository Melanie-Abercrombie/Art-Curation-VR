using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueGalleryMenu : MonoBehaviour {

    public float howHigh;
    GameObject menuManager;
    float currPos;

    void Start()
    {
        menuManager = GameObject.FindWithTag("SceneManager");
        currPos = transform.position.y;
        menuManager.GetComponent<MenuManager>().OpenGalleryStand();
        StartCoroutine(RaiseSelf(howHigh + currPos));

    }



    void OnColliderEnter()
    {
        menuManager.GetComponent<MenuManager>().OpenGalleryStand();
        StartCoroutine(RaiseSelf(howHigh));
    }
    

    IEnumerator RaiseSelf(float end)
    {
        for (int i = 0; i < 40 ; i++)
        {
            currPos += Mathf.Lerp(currPos, end, Time.deltaTime);
            Debug.Log("currPos: " + currPos);
            transform.position += new Vector3(0, currPos, 0);
            yield return null;
        }
 
    }

}
