using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunscript : MonoBehaviour
{
    public float deadzone = -15;
    public float movespeed = 1;
    public float rotationspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        transform.Rotate(Vector3.forward, rotationspeed * Time.deltaTime);

        if (transform.position.x < deadzone)
        {
            Debug.Log("Cloud despawned");
            Destroy(gameObject);
        }
    }
}
