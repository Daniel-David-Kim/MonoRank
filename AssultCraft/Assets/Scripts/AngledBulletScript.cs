using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngledBulletScript : MonoBehaviour
{
    public float hspeed = -2.0f;
    public float vspeed = -2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        if (this.transform.position.y <= -7) Destroy(gameObject);
    }

    void BulletMove()
    {
        this.transform.position += new Vector3(Time.deltaTime * hspeed, Time.deltaTime * vspeed, 0);
    }

}