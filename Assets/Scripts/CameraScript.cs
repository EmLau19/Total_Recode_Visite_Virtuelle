using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject player;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        //transform.rotation = player.transform.rotation;
        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = -1 * Input.GetAxis("Mouse Y");
        float mouse_z = Input.mousePosition.z;
        Vector3 rotation = new Vector3(mouse_y, mouse_x, 0);
        transform.eulerAngles += rotation; // Update rotation with the mouse location. Don't use Rotate
        player.transform.eulerAngles += new Vector3(0, mouse_x, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit))
            {
               
                Debug.Log("OK");
                //Transform objectHit = hit.transform;
                Vector3 point = hit.point;
                //Vector3 position = new Vector3(objectHit.position.x, 1f, objectHit.position.z);
                Vector3 position = new Vector3(point.x, 1f, point.z);
                player.transform.position = position;

                // Do something with the object that was hit by the raycast.
            }
        }
    }
}
