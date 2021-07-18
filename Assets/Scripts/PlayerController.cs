using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        
    }

    void Update()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        float y = transform.position.y + Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        y = Mathf.Clamp(y, -4.3f, 4.3f);

        transform.position = new Vector3(x, y, z);
    }
}
