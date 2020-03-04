using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBoundary : MonoBehaviour
{
  public AudioSource source;
    
    private void OntriggerEnter(Collider other)
        
    {
        source.Play();
        source.loop = true;
    }

    
        
    
}
