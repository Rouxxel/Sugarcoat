using UnityEngine;

public class pipespawner : MonoBehaviour
{

    public GameObject pipes;
    public float spawnrate=4;
    public float timer=0;

    public float highestpoint = 5;
    public float lowestpoint = -4;

    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
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
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {

     Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),-1),transform.rotation);

    }

}
