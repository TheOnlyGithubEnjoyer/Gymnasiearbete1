using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightPickup : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject FlashLight;
    void OnTriggerEnter() {
        FlashLight.SetActive(true);
        Destroy(this.flashlight);

    }
}
