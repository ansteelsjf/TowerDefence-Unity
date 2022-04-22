using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiate : MonoBehaviour
{
    public GameObject enemy;
    float timeAlive = 0.0f;
    bool instantiate = false;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 1)
        {
            timeAlive += Time.deltaTime;
            if (timeAlive > 3)
            {
                instantiate = true;
                timeAlive = 0f;
            }
        }
        if (index == 2)
        {
            timeAlive += Time.deltaTime;
            if (timeAlive > 2.5)
            {
                instantiate = true;
                timeAlive = 0f;
            }
        }
        if (index == 3)
        {
            timeAlive += Time.deltaTime;
            if (timeAlive > 2)
            {
                instantiate = true;
                timeAlive = 0f;
            }
        }


        if (instantiate)
        {
            GameObject newenemy = ObjectPool.SharedInstance.GetPooledObject();
            
            newenemy.transform.position = transform.position + transform.up;
            
            newenemy.SetActive(true);
            instantiate = false;
         
        }
    }
}
