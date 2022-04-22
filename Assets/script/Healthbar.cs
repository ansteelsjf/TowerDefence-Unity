
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public Image currentHealthbar;
    public Text ratioText;

    private float hitpoint = 150;
    private float maxHitpoint = 150;


    public Camera main_camera;
    public GameObject backgroundimage;
    public Animator anim;
   

    


    private void Start()
    {
       
        UpdateHealthbar();
        

    }

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString() + '%';
        
    }
    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        //Debug.Log(hitpoint);
        if (hitpoint < 0)
        {
            hitpoint = 0;
            
            StartCoroutine(Event());
            
            //Destroy(backgroundimage.gameObject);
            

        }
        UpdateHealthbar();
    }

    IEnumerator Event()
    {
        Animator anim;
        anim = this.GetComponent<Animator>();
        anim.SetInteger("state", 2);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;

        yield return new WaitForSeconds(3);
        this.gameObject.transform.position = new Vector3(-1f, 0f, 5f);
        anim.SetInteger("state", 0);
        agent.enabled = true;
        Vector3 position = new Vector3(1.91f, 0.48f, -6.19f);
        agent.SetDestination(position);
        hitpoint = 150;
       // moneysys.moneyreceive(1);
    }

    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;
        UpdateHealthbar();
    }
    void OnGUI()
    {

        Vector3 worldPosition = new Vector3(transform.position.x, transform.position.y +1.5f, transform.position.z);

        Vector2 position = main_camera.WorldToScreenPoint(worldPosition);

        //Debug.Log(position);

        backgroundimage.transform.position = position;

    }
}
