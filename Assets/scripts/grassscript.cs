using UnityEngine;

public class grassscript : MonoBehaviour
{
    public float deadzone = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.x < deadzone)
        {
            Debug.Log("Single grass despawned");
            Destroy(gameObject);
        }
    }
}
