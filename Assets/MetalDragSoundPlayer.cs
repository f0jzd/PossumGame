using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDragSoundPlayer : MonoBehaviour
{

    private Rigidbody2D rb;
    private AudioSource sound;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > 0.2f && !sound.isPlaying)
        {
            sound.clip = Resources.Load<AudioClip>("Audio/metalDragLoop");
            sound.Play();

            //sound.PlayOneShot(sound.clip);
            // Player is moving
            Debug.Log("ContainerIsMoving");
        }
        if (rb.velocity.magnitude < 0.2f && sound.isPlaying)
        {
            sound.Stop();
        }
    }
}
