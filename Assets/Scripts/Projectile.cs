using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float speed;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
        
    }

    private void OnTriggerEnter(Collider other) {

        var otherHealth = other.GetComponent<Health>();
        
        if (otherHealth == null) {
            Destroy(other.gameObject);
        } else {
            otherHealth.Damage(1);
        }

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
