using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    Transform go_target;
    GameObject go_target_obj;

    
    public Transform go_baseRotation;
    public Transform go_GunBody;
    public Transform go_barrel;

   
    public float barrelRotationSpeed;
    float currentRotationSpeed;

    public float firingRange;

  
    public ParticleSystem muzzelFlash;

    bool canFire = false;
    public moneysystem moneysys;
    public SpeedAdjust speedadjust;
    

    
    void Start()
    {
      
        this.GetComponent<SphereCollider>().radius = firingRange;
        
    }

    void Update()
    {
        AimAndFire();
        
        
    }

    void OnDrawGizmosSelected()
    {
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, firingRange);
    }

    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            go_target = other.transform;
            go_target_obj = other.gameObject;
            canFire = true;
        }

    }
   
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            canFire = false;

        }
    }

    void AimAndFire()
    {
        
        go_barrel.transform.Rotate(0, 0, currentRotationSpeed * Time.deltaTime);

        
        if (canFire)
        {
           
            currentRotationSpeed = barrelRotationSpeed;
            BroadcastMessage("rocketfire", true) ;

            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            Vector3 gunBodyTargetPostition = new Vector3(go_target.position.x, go_target.position.y, go_target.position.z);

            go_baseRotation.transform.LookAt(baseTargetPostition);
            go_GunBody.transform.LookAt(gunBodyTargetPostition);
            go_target_obj.SendMessageUpwards("TakeDamage", 5f* speedadjust.speed);
            
            moneysys.moneyreceive(1f* speedadjust.speed);
           
            if (!muzzelFlash.isPlaying)
            {
                muzzelFlash.Play();
                
            }
        }
        else
        {
            
            currentRotationSpeed = Mathf.Lerp(currentRotationSpeed, 0, 10 * Time.deltaTime);
            BroadcastMessage("rocketfire", false);

            if (muzzelFlash.isPlaying)
            {
                muzzelFlash.Stop();
            }
        }
    }
}