using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advice : MonoBehaviour
{
    [SerializeField]

    WarningMessage message;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log(message.Message);
        }
    }   
}   