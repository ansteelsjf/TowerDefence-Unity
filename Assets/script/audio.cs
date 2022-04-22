using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audiosource;
    public Pause pause;
    
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
