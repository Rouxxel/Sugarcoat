using UnityEngine;

public class grasschunk : MonoBehaviour
{
    public float deadzone = -24;
    public float movespeed = 5;

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
            Debug.Log("Chunk of grass despawned");
            Destroy(gameObject);
        }
    }
}
