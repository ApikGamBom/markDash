using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMap : MonoBehaviour
{
    public jump Jump;
    // jump jumpScript = FindObjectOfType<jump>();
    // bool valueFromjump = jumpScript.alive;
    public float levelSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Jump.alive == true)
        {
            transform.position += Vector3.left * levelSpeed * Time.deltaTime;
        }
        
    }
}
