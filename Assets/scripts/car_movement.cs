using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_movement : MonoBehaviour
{
    public float speed = 20f;
    public float rotation_speed = 90f;
   private Rigidbody car_rb;


    void Awake()
    {
        car_rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float movement = Input.GetAxis("Vertical");


        Quaternion delta_turn = Quaternion.Euler(Vector3.up * rotation * rotation_speed * Time.fixedDeltaTime);
        car_rb.MoveRotation(car_rb.rotation * delta_turn);

        Vector3 delta_pos = transform.forward * movement * speed * Time.fixedDeltaTime;
        car_rb.MovePosition(car_rb.position + delta_pos);
        
    }
}
