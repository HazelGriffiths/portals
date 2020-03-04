using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandController : MonoBehaviour
{

    float moveSpeed = 10f;

    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {

            this.transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);




        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }

    }

}





