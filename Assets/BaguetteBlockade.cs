using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaguetteBlockade : MonoBehaviour
{

    public GameObject baguetteBlockade;




    // Start is called before the first frame update
    void Start()
    {

        baguetteBlockade.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            baguetteBlockade.SetActive(false);
        }
    }
}
