using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion_de_coliciones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
}
