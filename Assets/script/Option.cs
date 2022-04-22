using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public void Play()
    {
        level1.SetActive(true);
        level2.SetActive(true);
        level3.SetActive(true);
        
    }
}
