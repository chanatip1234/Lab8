using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 12f;
    public float turnSpeed = 200f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        
        transform.position += transform.forward * move * speed * Time.deltaTime;

        
        transform.Rotate(0f, turn * turnSpeed * Time.deltaTime, 0f);
    }
}