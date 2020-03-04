using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRenderQueue : MonoBehaviour
{
    private List<Renderer> doorRenderers = new List<Renderer>();
    private GameObject doorParent;

    // Start is called before the first frame update
    void Start()
    {
        doorParent = this.gameObject;
        for (int i = 0; i < doorParent.transform.childCount; i++)
        {
            doorRenderers.Add(doorParent.transform.GetChild(i).GetComponent<Renderer>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
