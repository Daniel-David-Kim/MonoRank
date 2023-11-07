using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScriptC : MonoBehaviour
{
    public float speed = -3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (this.transform.position.y <= -6) Destroy(gameObject);
    }

    void Move()
    {
        this.transform.position += new Vector3(0, Time.deltaTime * speed, 0);
    }

}
