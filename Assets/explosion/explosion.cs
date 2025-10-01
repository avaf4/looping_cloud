using UnityEngine;

public class explosion : MonoBehaviour
{
    public float disappearTime = 1f;

    float futureTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // after a certain amount of time, self-destruct
        Invoke("selfDestruct", disappearTime);

    }

    void selfDestruct()
    {
        Destroy(gameObject);
    }
}


