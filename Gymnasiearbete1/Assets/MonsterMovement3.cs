
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement3 : MonoBehaviour
{
    public float moveSpeed;
        void Start()
    {
        
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