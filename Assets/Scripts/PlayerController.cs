using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool groundCheck;
    public LayerMask groundLayer;
    public bool canJump;
    public Vector3 centerofmass;
    private IEnumerator coroutine;
    private bool walking = false;
    public GameObject hiddenBaguette;
    public GameObject houseColliders;

    public AudioSource sound;
    public AudioSource AudioSource;

    Rigidbody2D rb;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();

        hiddenBaguette.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        rb.centerOfMass = centerofmass;

        



        if (Input.GetKeyDown("space") && groundCheck)
        {
            walking = false;
            rb.AddForce(new Vector3(0, jumpForce));
            sound.Stop();
            sound.clip = Resources.Load<AudioClip>("Audio/jump");
            sound.Play();


            //canJump = true;


        }

        //if (Input.GetKeyUp("space") && !groundCheck)
        //{

        //    canJump = false;

        //}
        //if (canJump == true)
        //{
        //    canJump = false;
            

        //}
        if (Input.GetKeyDown("s") && !sound.isPlaying)
        {
            sound.PlayOneShot(sound.clip);
        }
        

    }
    void FixedUpdate()
    {

        groundCheck = Physics2D.OverlapArea(new Vector2(transform.position.x - 3.15f, transform.position.y - 2.45f),
            new Vector2(transform.position.x + 3.15f, transform.position.y + 2.45f), groundLayer);

        if (groundCheck == true)
        {
            walking = true;
        }

        if (walking == true)
        {
            float move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(speed * move, rb.velocity.y);

            if (rb.velocity.magnitude > 0.1f && !sound.isPlaying && groundCheck == true)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/walk_");
                sound.Play();

                //sound.PlayOneShot(sound.clip);
                // Player is moving
                Debug.Log("PlayerIsMoving");
            }
            if (rb.velocity.magnitude < 0.1f && sound.isPlaying)
            {
                sound.Stop();
            }

        }
              

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Puzzle5BaguetteBait")
        {
            hiddenBaguette.SetActive(true);
        }
        if (other.name == "Puzzle6BaguetteBait")
        {
            hiddenBaguette.SetActive(true);
            houseColliders.SetActive(false);

        }


        if (other.name == "B_Collider")
        {
            sound.Play();
        }
        if (other.name == "Baguette_Puzzle1")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);


            AudioSource.clip = Resources.Load<AudioClip>("Audio/juicyBite");
            AudioSource.PlayOneShot(AudioSource.clip);
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.name == "Puzzle2_Baguette")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);


            AudioSource.clip = Resources.Load<AudioClip>("Audio/carHonk");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
        if (other.name == "Puzzle4Baguette")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);

            AudioSource.clip = Resources.Load<AudioClip>("Audio/hissing");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
        if (other.name == "BaguettePuzzle3")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);

            AudioSource.clip = Resources.Load<AudioClip>("Audio/someweirdsound");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
        if (other.name == "BaguettePuzzle3")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);

            AudioSource.clip = Resources.Load<AudioClip>("Audio/someweirdsound");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
        if (other.name == "Puzzle5_Baguette")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);

            AudioSource.clip = Resources.Load<AudioClip>("Audio/explosion");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
        if (other.name == "Puzzle6Baguette")
        {
            coroutine = soundDelayer(2.0f);
            StartCoroutine(coroutine);

            AudioSource.clip = Resources.Load<AudioClip>("Audio/fart");
            AudioSource.PlayOneShot(AudioSource.clip);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y),
            new Vector2(6.3f,2.9f));

         //Gizmos.color = Color.red;
        
        
        //Gizmos.DrawSphere(transform.position + transform.rotation * centerofmass, 1f);

    }
    private IEnumerator soundDelayer(float waitTime)
    {
        Debug.Log("coroutine Started");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

   
    

}
