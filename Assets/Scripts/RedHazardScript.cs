using UnityEngine;

public class RedHazardScript : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 2.5f;
    public GameObject MirrPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Following Player.1
        //transform.position = Vector3.MoveTowards(transform.position, MirrPlayer.transform.position, Time.deltaTime * 3);

        //Following Player.2
        Vector2 vel = new Vector2(0, 0);
        vel = (Vector2)(MirrPlayer.transform.position - transform.position);
        vel = vel.normalized * 3;
        RB.linearVelocity = vel;
    }
}
