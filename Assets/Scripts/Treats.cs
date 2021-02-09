using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treats : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "playercat")
            Destroy(gameObject);
    }
}
