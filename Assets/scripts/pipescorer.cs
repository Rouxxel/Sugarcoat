using Unity.VisualScripting;
using UnityEngine;

public class pipescorer : MonoBehaviour
{
    public logicscript logic;
    public int pointtoadd = 1;
    public playerscript player;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GameObject().tag == "Player" && player.playercontrol == true)
        {
            logic.addscore(pointtoadd);
        }
    }
}
