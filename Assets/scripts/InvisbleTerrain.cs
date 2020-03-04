using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisbleTerrain : MonoBehaviour

{
    public int renderqueue;
	public Terrain terrain1;
    private Material terrainMaterial;
    void Awake()
    {
        terrain1.materialTemplate.renderQueue = 2000;
        terrainMaterial = terrain1.GetComponent<Material>();
        terrainMaterial.renderQueue = 2000;
        Debug.Log(terrain1.materialTemplate.renderQueue);
    }

    // Update is called once per frame
    private void Update()
    {
       // terrain1.materialTemplate.renderQueue = renderqueue;
    }

    //private void Start()
    //{
    //    //terrain2.GetComponent<Terrain>().enabled = false;
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //print(collision.gameObject);
    //    terrain2.GetComponent<Terrain>().enabled = true;
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    terrain2.GetComponent<Terrain>().enabled = false;
    //}



}
