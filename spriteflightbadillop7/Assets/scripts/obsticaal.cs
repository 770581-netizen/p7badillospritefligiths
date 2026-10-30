using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float minsize = 0.5f;
    float maxsize = 2.0f;
    Rigidbody2D rb;
    float minspeed = 50f;
    float maxspeed = 150f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomsize = Random.Range(minsize, maxsize);
        transform.localScale = new Vector3(randomsize, randomsize, 1);

        rb = GetComponent<Rigidbody2D>();

        float randomspeed = Random.Range(minspeed, maxspeed);
        rb.AddForce(Vector2.right * 100);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}

internal class vector3
{
    private int v1;
    private int v2;
    private int v3;

    public vector3(int v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}