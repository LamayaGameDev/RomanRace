using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPlatform : MonoBehaviour
{
    public bool isCorrect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            AudioManager.instance.PlayFail();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            AudioManager.instance.PlaySuccess();
        }
    }
       
}
