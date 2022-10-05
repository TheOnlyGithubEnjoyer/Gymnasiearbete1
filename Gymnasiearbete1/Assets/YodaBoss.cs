using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YodaBoss : MonoBehaviour
{
    public float moveSpeed;

    public Transform target;
    // Start is called before the first frame update public float moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame

        void OnTriggerStay(Collider other) 
        {
            
        transform.Translate(Vector3.down * moveSpeed * 10f * Time.deltaTime); 
        }
                void OnTriggerExit(Collider other) 
        {
            transform.Translate(Vector3.down * moveSpeed * 10f * Time.deltaTime);
            transform.Rotate(0,0,-90);
            

            
        }

}
