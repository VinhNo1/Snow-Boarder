using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLV : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float magicNumber = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player") 
        {
            finishEffect.Play();
           GetComponent<AudioSource>().Play();
           Invoke("ReloadScene", magicNumber);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
