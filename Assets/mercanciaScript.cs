﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
