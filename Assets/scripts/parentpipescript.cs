using UnityEngine;

public class parentpipescript : MonoBehaviour
{

    public float movespeed = 5;
    public float deadzone = -13;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < deadzone) {
            Debug.Log("Pipes despawned");
            Destroy(gameObject);
        }
    }
}
