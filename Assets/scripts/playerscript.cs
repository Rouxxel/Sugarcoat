using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerscript : MonoBehaviour
{

    public Rigidbody2D physicalbody;
    public float flapstrength = 10;
    public bool playercontrol = true;

    public AudioSource flapeffect;

    public float xdeadzone = -13;
    public float ydeadzone = -7;

    public logicscript logic;
    public bool playercollided=false;

    public float rotationspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playercontrol == true)
        {
            transform.Rotate(Vector3.forward, rotationspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)== true && playercontrol == true)
        {
            physicalbody.velocity = Vector2.up * flapstrength;
            flapeffect.Play();
        }

        if (transform.position.x < xdeadzone || transform.position.y < ydeadzone)
        {
            Debug.Log("Player despawned");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    
    {

        if (playercollided == false)
        {
            logic.gameoverscreen();
            playercontrol = false;

            if (collision.gameObject.tag == "Wall")
            {
                physicalbody.velocity = Vector2.left * 20;
            }
            else
            {
                physicalbody.velocity = Vector2.left * 10;
                physicalbody.velocity = physicalbody.velocity + Vector2.up * 4;
            }

            playercollided = true;
        }
        
    }
}
