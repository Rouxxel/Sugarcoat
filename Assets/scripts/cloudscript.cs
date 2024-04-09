using UnityEngine;

public class cloudscript : MonoBehaviour
{

    public float deadzone = -14;
    public float movespeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Debug.Log("Cloud despawned");
            Destroy(gameObject);
        }
    }

}
