using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YodaBoss : MonoBehaviour
{
    public float moveSpeed;
    public float max_health = 1000f;

    public float cur_health = 0f;
    public bool alive = true;
    public AudioSource soundSource;

    void Start() {
    cur_health = max_health;
    soundSource = GetComponent<AudioSource> (); 
    GetComponent<AudioSource>().Play();

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
        // void Death(){
        //     if(HP == 0)
        //     {
        //         Destroy(this.gameObject);
        //     }
        // }

    

        void Update() {
            transform.Translate(Vector3.forward * moveSpeed * 10f * Time.deltaTime);
        }

        void OnTriggerEnter(Collider other) {
            transform.Rotate(0, -180, 0);
        }
    


        // void OnTriggerStay(Collider other) 
        // {
            
        // transform.Translate(Vector3.down * moveSpeed * 10f * Time.deltaTime); 
        // }
        //     void OnTriggerExit(Collider other) 
        // {
        //     transform.Translate(Vector3.down * moveSpeed * 10f * Time.deltaTime);
        //     transform.Rotate(0,0,-90);
            
            
        // }

}
