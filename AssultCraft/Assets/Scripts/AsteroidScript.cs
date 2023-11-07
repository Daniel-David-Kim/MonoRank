using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    // max limit
    public float xlim = 8.4f;
    //private float xlim = 4.4f;
    private float hspeed = 3.0f;
    private float vspeed = 3.0f;
    private float hpos = -1.0f;
    private float vpos = -1.0f;
    private int score = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.position.x >= 0) hpos *= (-1.0f); 
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
        // -8.4 <-> 8.4 
        if ((this.transform.position.x >= xlim)||(this.transform.position.x <= xlim*(-1.0f))) hpos *= (-1.0f);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag.Equals("playerBullet"))
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + score);
            Destroy(gameObject);
        }
    }

}
