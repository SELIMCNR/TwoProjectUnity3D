using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonMobile : MonoBehaviour
{
    public AudioSource[] audioSources;
    // Start is called before the first frame update
    void Start()
    {
        foreach(AudioSource audiosource in audioSources) 
        {
            Button button = audiosource.GetComponent<Button>();
            button.onClick.AddListener(() => PlaySound(audiosource));


        }
        
    }

    private void PlaySound(AudioSource audioSource)
    {
        foreach(AudioSource Source in audioSources)
        {
            Source.Stop();
        }
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void t�kland�()
    {
        Debug.Log("t�kland�");
        //event trigger  tetikleme olay� eklemeli objeye
        /*
         pointer enter: tek sefer �al���r
        pointer down: pointerup gibi �zellikler var.
         
         */
    }
}
