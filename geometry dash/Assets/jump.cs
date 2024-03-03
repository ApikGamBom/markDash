using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    public bool alive;
    public GameObject UI;
    public Rigidbody2D RB;
    public float jumpStrength;
    public bool inAir = false;
    public bool isReversed;
    // Start is called before the first frame update
    void Start()
    {
        RB= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && inAir == false && alive && isReversed == false)
        {
            inAir = true;
            RB.velocity = Vector2.up * jumpStrength;
        }
        if (Input.GetKey(KeyCode.Mouse0) && inAir == false && alive && isReversed == true)
        {
            inAir = true;
            RB.velocity = Vector2.up * jumpStrength * -1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.name == "floor" || collidedObject.name == "block")
        {
             inAir = false;
        }
        if (collidedObject.name == "spike")
        {
            deathUI();
            alive = false;
        }
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.name == "reversePortal")
        {
            RB.gravityScale *= -1;
            isReversed = !isReversed;
            Debug.Log("If you see this, you hit the Reverse Portal");
        }
            
    }
    private void deathUI()
    {
        UI.SetActive(true);
    }
}
