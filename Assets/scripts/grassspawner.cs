using UnityEngine;

public class grassspawner : MonoBehaviour
{
    public GameObject chunkgrass;
    public float spawnrate = 4;
    public float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        spawngrass();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawngrass();
            timer = 0;
        }
    }

    void spawngrass()
    {

        Instantiate(chunkgrass, transform.position, transform.rotation);

    }

}
