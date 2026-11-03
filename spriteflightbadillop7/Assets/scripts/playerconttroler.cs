using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Mouse.current.leftButton.isPressed){
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value); 
            Debug.Log("Mouse position:" + mousepos);

            Vector3 direction = mousepos - transform.position;
            transform.up = direction;
        }
    }
}
