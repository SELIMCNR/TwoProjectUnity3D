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
                Debug.Log("Kullan�c� dokundu");
            }
            if (dokun.phase == TouchPhase.Stationary)
            {
                Debug.Log("Kullan�c� Ekrana bas�l� tutuyor");
            }
            if (dokun.phase == TouchPhase.Moved)
            {
                Debug.Log("Kullan�c� hareket ettiriyor.");
            }
            if (dokun.phase == TouchPhase.Ended)
            {
                Debug.Log("Kullan�c� hareketi bitirdi");
            }
        }
    }
}
