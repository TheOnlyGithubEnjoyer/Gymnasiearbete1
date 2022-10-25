using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsSoundMovement : MonoBehaviour
{
    public float moveSpeed;

    public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = GetComponent<AudioSource> (); 

    }        
        void Update() {
            transform.Translate(Vector3.forward * moveSpeed * 10f * Time.deltaTime);
            GetComponent<AudioSource>().Play();
        }
            void OnTriggerEnter(Collider other) {
            transform.Rotate(0, -180, 0);
        }
    
        


}
