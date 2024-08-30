using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour
{
    
    public float fallingtime;

    private TargetJoint2D target;
    private BoxCollider2D boxColl;

    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();

    }

   void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Player")
      {
          Invoke("Falling", fallingtime);
      }
}

void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 8)
      {
        Destroy(gameObject);
      }
    }
    void Falling()
    {
        target.enabled = false;
        boxColl.isTrigger = true;
    }
}
