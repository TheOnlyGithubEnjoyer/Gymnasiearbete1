using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource soundSource;
    void Start()
    {
        soundSource = GetComponent<AudioSource> (); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision) {
            soundSource.Play ();
    }
    void OnTriggerExit(Collider colliison){
        Destroy (this.gameObject);
    }
}
