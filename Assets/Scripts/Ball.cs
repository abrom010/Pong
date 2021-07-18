using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float drasticity;
    Vector2 velocity;
    
    void Start()
    {
        velocity = new Vector2(-speed, 0);
    }
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * velocity.x, Time.deltaTime * velocity.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BounceWall")
        {
            velocity = new Vector2(velocity.x, -velocity.y);
        }
        else if (collision.gameObject.tag == "KillWall")
        {
            SceneManager.LoadScene("GameOver");
            Application.Quit();
        }
        else if (collision.gameObject.tag == "Paddle")
        {
            float x = -velocity.x;
            float y = drasticity * (transform.position.y - collision.transform.position.y);
            
            velocity = new Vector2(x, y);
        }
    }

}
