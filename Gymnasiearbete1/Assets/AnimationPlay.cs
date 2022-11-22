using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{

    public Animation anim;

    void start () {
        anim = GetComponent<Animation> ();
    }
    
     void OnTriggerEnter(Collider collision) {
        anim.Play();
     }
}
