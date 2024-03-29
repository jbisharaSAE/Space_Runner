﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointInfo : MonoBehaviour
{
    public int wayPointNumber;

    [SerializeField] GameObject player;

    private bool isTrigger;

    private void Start()
    {
        //transform.parent = null;    
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);

        if (isTrigger)
        {
            player.GetComponent<PlayerController>().currentIndex = wayPointNumber;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTrigger = false;
        }
    }

}
