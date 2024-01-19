using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public BoxCollider2D playerCollider;
    public BoxCollider2D dashCollider;
    public float stun = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stun < 1)
        {
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 pos = transform.position;
                pos.x = pos.x + (600*Time.deltaTime);
                transform.position = pos;
            }
        }
    }
}
