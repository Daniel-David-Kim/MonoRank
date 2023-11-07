using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    private float speed = 9.0f;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Invoke("DestroyBullet", 2);
    }

    void Move()
    {
        this.transform.position += new Vector3(0, Time.deltaTime * speed, 0);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

}
