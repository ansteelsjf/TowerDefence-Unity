using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Rocketexplode : MonoBehaviour
    {

        public float speed = 100;
        public LayerMask collisionLayerMask;

        public GameObject rocketExplosion;

        public MeshRenderer projectileMesh;
        private bool targetHit;

        public AudioSource inFlightAudioSource;

        public ParticleSystem disableOnHit;
        Transform go_target;
        GameObject go_target_obj;



        private void Update()
        {
            go_target_obj.SendMessageUpwards("TakeDamage", 150f);
            if (targetHit) return;
            transform.position += transform.forward * (speed * Time.deltaTime);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (!enabled) return;
            if (other.gameObject.tag == "Enemy")
            {
                go_target = other.transform;
                go_target_obj = other.gameObject;
            }
            Explode();
            projectileMesh.enabled = false;
            targetHit = true;
            inFlightAudioSource.Stop();
            foreach(Collider col in GetComponents<Collider>())
            {
                col.enabled = false;
            }
            disableOnHit.Stop();
            Destroy(gameObject, 5f);
        }

        private void Explode()
        {
            GameObject newExplosion = Instantiate(rocketExplosion, transform.position, rocketExplosion.transform.rotation, null);

        }
    }
