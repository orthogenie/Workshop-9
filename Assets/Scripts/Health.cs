using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializedField] int health = 2;

    public void Damange(int damage) {
        health -= damage;

        if (health == 1) {
            GetComponent<Material>();
        } else if (health <= 0) {
            Destroy(gameObject);
        }
    }
    
}
