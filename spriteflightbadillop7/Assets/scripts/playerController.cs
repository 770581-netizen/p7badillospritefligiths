using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    private float elapsedyime = 0f;
    public float thrustForce = 1f;
    Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*private T GetComponet<T>()
    {
        throw new NotImplementedException();
    }*/

    // Update is called once per frame
    void Update()
    {
      if(Mouse.current.leftButton.isPressed)
        {
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value); 
            Debug.Log("Mouse position:" + mousepos);

            Vector2 direction = (mousepos - transform.position).normalized;
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
        }
    }
}
