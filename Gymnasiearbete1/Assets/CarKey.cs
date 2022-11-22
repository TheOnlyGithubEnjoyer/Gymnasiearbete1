using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarKey : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter() {
        Destroy(this.gameObject);

    }
}
