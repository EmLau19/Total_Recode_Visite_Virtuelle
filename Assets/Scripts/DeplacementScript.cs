using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementScript : MonoBehaviour
{
    private GameObject camera;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(Time.deltaTime * x * speed, .0f, Time.deltaTime * z * speed);

        transform.Translate(movement);
    }
}
