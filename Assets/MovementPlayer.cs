using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private Rigidbody rb;
    //create simple movement script
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized;
        rb.velocity = movement * moveSpeed;
        GetComponent<CharacterController>().Move(movement * moveSpeed * Time.deltaTime);
    }
}
