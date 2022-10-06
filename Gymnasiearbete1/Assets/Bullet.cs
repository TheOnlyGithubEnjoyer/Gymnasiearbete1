using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float life = 3;

    float bulletDamage = 100f;

    void Awake() {
        Destroy(gameObject, life);    
    }
    void OnTriggerEnter(Collider other) {
        // Destroy(gameObject);
        other.gameObject.GetComponent<YodaBoss> ().TakeDamage (bulletDamage);
    }

          
}
