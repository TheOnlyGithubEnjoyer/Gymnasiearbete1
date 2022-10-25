using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{

    public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = GetComponent<AudioSource> (); 

    }

    // Update is called once per frame
     void Update()
 { 
  // If the left mouse button is pressed down...
  if(Input.GetMouseButtonDown(0) == true)
  {
   GetComponent<AudioSource>().Play();
  } 
  // If the left mouse button is released...

 }
}
