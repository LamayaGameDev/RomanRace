using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRe : MonoBehaviour
{
    string tagName = "Player";
    [SerializeField] private Transform respawnPoint;
    
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == tagName)
        {
            other.transform.position = respawnPoint.transform.position;
        }   
      
    }
}
