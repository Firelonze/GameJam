using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activations : MonoBehaviour
{
    [SerializeField] private GameObject[] followers;
    private int AmountOfFollowers;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player" || transform.position.x < 142)
        { 
            Instantiate(followers[AmountOfFollowers]);
            AmountOfFollowers++;
        }
        else
        {
            for (int i = 0; i < followers.Length; i++)
            {
                Destroy(followers[i]);
            }
        }
    }

}
