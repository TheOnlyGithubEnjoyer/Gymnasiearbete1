
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement3 : MonoBehaviour
{
    public float max_health = 1000f;

    public float cur_health = 0f;
    public bool alive = true;
    public float moveSpeed;
        void Start()
    {
        cur_health = max_health;
    }

     public void TakeDamage(float amount)
    {
    if (!alive)
    {
        return;
    }
    if (cur_health <= 0)
    {
        cur_health = 0;
        alive = false;
        gameObject.SetActive (false);
    }

        cur_health -= amount;
    }

    // Update is called once per frame

        void OnTriggerStay(Collider other) 
        {
            
        transform.Translate(Vector3.forward * moveSpeed * 10f * Time.deltaTime);
            
        }
        //         void OnTriggerExit(Collider other) 
        // {
            
        //     Destroy(this.gameObject);
        // }
}