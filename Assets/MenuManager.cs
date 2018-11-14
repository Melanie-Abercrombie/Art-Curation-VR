using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public List<GameObject> Galleries;
    public List<GameObject> GalleryStands;
    public List<GameObject> Sculptures;
    //rotate gallery type
    //rotate gallery selection menu


        //test framerate
    void Start()
    {
        OpenGalleryStand();

    }




    public void OpenGalleryStand()
    {
        print("opening Gallery");
        StartCoroutine(RotateY(GalleryStands[0], 180));
        StartCoroutine(RotateY(GalleryStands[1], 180));

        for (int i = 0; i < Sculptures.Count; i++)
        {
            StartCoroutine(Spin(Sculptures[i]));
        }
    }




    IEnumerator RotateY(GameObject go, float angle)
    {
        for (int i = 0; i < angle; i++)
        {
        go.transform.RotateAround(go.transform.position, Vector3.down, 1);
        yield return null;
        }
    }


    IEnumerator Spin(GameObject go)
    {
        go.transform.RotateAround(go.transform.position, Vector3.down, 1);
        yield return null;
        StartCoroutine(Spin(go));
    }

}
