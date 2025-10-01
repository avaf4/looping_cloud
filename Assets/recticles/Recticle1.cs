using UnityEngine;

public class Recticle1 : MonoBehaviour
{
    public float speed = 0.05f;
    public float MaxY = 4.5f;

    public GameObject Explosion;

    public GameObject Recticle2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        // when within the Min and Max Y bounds, the recticle can be moved
        if (transform.position.y >= -MaxY && transform.position.y <= MaxY)
        {
            transform.Translate(y * speed * Vector2.up);
        }
        // if x surpasses the Max X value, transform the position of the object to the Max X
        else if (transform.position.y > MaxY)
        {
            Vector3 offset = transform.position - Vector3.up * MaxY;
            transform.position -= Vector3.up * offset.y;
        }
        // if x surpasses the Min X value, transform the position of the object to the Min X
        else if (transform.position.y < -MaxY)
        {
            Vector3 offset = transform.position - Vector3.down * MaxY;
            transform.position += Vector3.down * offset.y;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject obj, rec2;
            obj = Instantiate(Explosion);
            rec2 = Recticle2;

            Vector3 offsetX =  rec2.transform.position;
            Vector3 offsetY =  transform.position;

            // move the fireball to the dragon's position
            obj.transform.position = Vector3.right * offsetX.x + Vector3.up * offsetY.y;
        }
    }
}
