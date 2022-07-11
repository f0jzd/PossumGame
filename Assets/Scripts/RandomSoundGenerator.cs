using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundGenerator : MonoBehaviour
{

    private float soundChooser;
    private AudioSource sound;
    private float update;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //yield return new WaitForSeconds(1);

       

        update += Time.deltaTime;
        {
            soundChooser = Random.Range(1f, 70f);
            



            if (soundChooser > 0 && soundChooser < 10)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/juicyBite");
            }
            if (soundChooser > 10 && soundChooser < 20)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/carHonk");
            }
            if (soundChooser > 20 && soundChooser < 30)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/hissing");
            }
            if (soundChooser > 30 && soundChooser < 40)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/jump");
            }
            if (soundChooser > 40 && soundChooser < 50)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/jump2");
            }
            if (soundChooser > 50 && soundChooser < 60)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/someweirdsound");
            }
            if (soundChooser > 60 && soundChooser < 70)
            {
                sound.clip = Resources.Load<AudioClip>("Audio/walk_");
            }
            //if (soundChooser > 70 && soundChooser < 80)
            //{
            //    Resources.Load<AudioClip>("Resources/juicyBite");
            //}
            //if (soundChooser > 80 && soundChooser < 90)
            //{
            //    Resources.Load<AudioClip>("Resources/juicyBite");
            //}
        }

    }
    void FixedUpdate()
    {

        
        
    }

}
