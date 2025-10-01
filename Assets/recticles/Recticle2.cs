using UnityEngine;

public class Recticle2 : MonoBehaviour
{
    public float speed = 0.01f;
    public float MaxX = 7.7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        // when within the Min and Max X bounds, the recticle can be moved
        if (transform.position.x >= -MaxX && transform.position.x <= MaxX)
        {
            transform.Translate(x * speed * Vector2.down);
        }
        // if x surpasses the Max X value, transform the position of the object to the Max X
        else if (transform.position.x > MaxX)
        {
            Vector3 offset = transform.position - Vector3.right * MaxX;
            transform.position -= Vector3.right * offset.x;
        }
        // if x surpasses the Min X value, transform the position of the object to the Min X
        else if (transform.position.x < -MaxX)
        {
            Vector3 offset = transform.position - Vector3.left * MaxX;
            transform.position += Vector3.left * offset.x;
        }
    }
}