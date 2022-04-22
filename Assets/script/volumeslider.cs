using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeslider : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer audiomixer;

    public void Setvolume(float value)
    {
        audiomixer.SetFloat("Mainvolume",value);
    }
}
