using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionRelative : MonoBehaviour
{
    public GameObject mark;
    public float camOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mark.transform.position.y > 2)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = mark.transform.position.y + camOffset;
            transform.position = newPosition;
        }
        else
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 0;
            transform.position = newPosition;
        }
    }
}
