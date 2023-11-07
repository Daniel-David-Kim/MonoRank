using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagBulletScript : MonoBehaviour
{
    // max limit
    public float xoffset = 2.0f;
    //private float xlim = 4.4f;
    private float hspeed = 3.0f;
    private float vspeed = 3.0f;
    private float hpos = -1.0f;
    private float vpos = -1.0f;
    public float flag = 1.0f;
    private float standardX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //if (this.transform.position.x >= 0) hpos *= flag;
        hpos *= flag;
        standardX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -6) Destroy(gameObject);
        Move();
    }

    void Move()
    {
        this.transform.position += new Vector3(Time.deltaTime * hspeed * hpos, Time.deltaTime * vspeed * vpos, 0);
        // -xlim <-> xlim
        if ((this.transform.position.x >= standardX + xoffset) || (this.transform.position.x <= standardX - xoffset)) hpos *= (-1.0f);
    }

}
