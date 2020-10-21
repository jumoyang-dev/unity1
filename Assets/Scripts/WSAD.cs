using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSAD : MonoBehaviour
{
    public float speed = 0.02f;
    public float border = 5.5f;

    public KeyCode up = KeyCode.W;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Over and over");

        Vector3 newPosition = transform.position;

        if(Input.GetKey(up))
        {
            Debug.Log("W is Pressed");
            newPosition.y += speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            newPosition.y -= speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            newPosition.x -= speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            newPosition.x += speed;
        }

        if(newPosition.y > border)
        {
            newPosition.y = -border;
        }

        transform.position = newPosition;
    }
}
