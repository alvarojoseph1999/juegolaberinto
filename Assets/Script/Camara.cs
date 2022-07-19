using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform pos1era, pos3era;
    private bool vista;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            vista = true;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            vista = false;
        }
        if (vista == true)
        {
            transform.position = Vector3.Lerp(transform.position, pos1era.position, 5 * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, pos3era.position, 5 * Time.deltaTime);
        }
    }
}
