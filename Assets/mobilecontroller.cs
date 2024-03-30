using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch dokun = Input.GetTouch(0);
            if(dokun.phase == TouchPhase.Began)
            {
                Debug.Log("Kullanýcý dokundu");
            }
            if (dokun.phase == TouchPhase.Stationary)
            {
                Debug.Log("Kullanýcý Ekrana basýlý tutuyor");
            }
            if (dokun.phase == TouchPhase.Moved)
            {
                Debug.Log("Kullanýcý hareket ettiriyor.");
            }
            if (dokun.phase == TouchPhase.Ended)
            {
                Debug.Log("Kullanýcý hareketi bitirdi");
            }
        }
    }
}
