using UnityEngine;

public class cloudspawnerscript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnrate = 4;
    public float timer = 0;

    public float lowestpoint = 4;
    public float highestpoint = 4;

    // Start is called before the first frame update
    void Start()
    {
        spawncloud();
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
            spawncloud();
            timer = 0;
        }
    }

    void spawncloud()
    {

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 1), transform.rotation);

    }
}
