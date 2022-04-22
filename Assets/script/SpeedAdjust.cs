using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAdjust : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public void Start()
    {
        Time.timeScale = 1;
        speed = 1;
    }
    public void SetSpeed(float value)
    {
        speed = value;
        Time.timeScale = value;
    }
}
