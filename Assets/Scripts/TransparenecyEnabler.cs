using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenecyEnabler : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D bc;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Enabler")
        {
            rb.isKinematic = true;
            bc.enabled = !bc.enabled;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }
}
