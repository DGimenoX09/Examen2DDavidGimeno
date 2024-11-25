using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Estrella : MonoBehaviour
{
    private bool interactable;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && interactable)
        {
            SceneManager.LoadScene("Victory"); 
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            interactable = true; 
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            interactable = false; 
        }
    }
}

