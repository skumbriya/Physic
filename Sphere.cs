using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    static int score = 0;
    static int bad = 0;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        Destroy(gameObject);
        score++;
        if(score == 6) {
            print("Выигрыш");
        }
    }

    void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "danger") {
            bad++;
            Destroy(gameObject);
        }

        if(col.gameObject.tag == "good") {
            rb.AddForce(0, 200f, 0);
        }

        if(bad == 6) {
            print("Проигрыш");
        }
    }
}
