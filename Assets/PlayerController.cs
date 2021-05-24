using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade;
    private Rigidbody fisica;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
        velocidade = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        fisica.AddForce(movement * velocidade);

    }
    
}