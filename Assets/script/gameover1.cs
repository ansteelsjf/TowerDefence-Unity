using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover1 : MonoBehaviour
{
    // Start is called before the first frame update

  
    public int index;
    public void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
     
            SceneManager.LoadScene(7);
            
        }

    }

}
