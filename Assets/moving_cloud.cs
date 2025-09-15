using UnityEngine;

public class moving_cloud : MonoBehaviour
{
    private Vector3 position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = gameObject.transform.position;
    }

    void Update()
    {
        transform.Translate(0.01f, 0f, 0f);
        if (transform.position.x > 16f)
        {
            transform.position = new Vector3(-16f, transform.position.y, transform.position.z);
        }
    }
}
