using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2 : MonoBehaviour
{
    Rigidbody rBody;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = -20f;
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector3(0, 0, speed);
    }
}
