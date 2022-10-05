using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject Tec9View;
    public GameObject Tec9;
    void OnTriggerEnter() {
        Tec9.SetActive(true);
        Destroy(this.Tec9View);

    }
}
