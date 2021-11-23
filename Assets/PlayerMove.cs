using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 local = transform.localPosition;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("w press");
            transform.position = Vector3.Lerp(local, local + Vector3.forward, speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("a press");
            transform.position = Vector3.Lerp(local, local + Vector3.left, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("s press");
            transform.position = Vector3.Lerp(local, local + Vector3.back, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("d press");
            transform.position = Vector3.Lerp(local, local + Vector3.right, speed * Time.deltaTime);
        }
    }

}
