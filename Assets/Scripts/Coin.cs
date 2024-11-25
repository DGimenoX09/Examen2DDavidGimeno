using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool interactable;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) && interactable)
        {
            Destroy(gameObject); 
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





























//tengo un script que cunado en un objeto en forma de moneda se destruye lo que quiero esque lo destruya y tenga un canvas que ponga cuantas monedas he recojido