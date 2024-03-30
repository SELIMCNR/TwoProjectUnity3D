using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ivmeMobil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // cihaz yatay
        float yanHareket = Input.acceleration.x;
        //cihaz dikey
        float dikHareket = Input.acceleration.y;

        //objeyi hareket ettir
        gameObject.transform.Translate(0, 0, dikHareket);

    }
}
