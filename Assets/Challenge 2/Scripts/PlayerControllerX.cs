using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    public float shotInterval = 3;
    void Start() {
        InvokeRepeating("Timer", 0, 1);
    }
    void Timer(){
        shotInterval++;
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(shotInterval > 2) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                shotInterval = 0;
            }
        }
    }
}
