using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingUnitScript : MonoBehaviour
{
    public float xlim = 8.28f;
    private float hspeed = 2.0f;
    private float vspeed = 2.0f;
    private float hpos = -1.0f;
    private float vpos = -1.0f;
    private int score = 25;
    private int hp = 150;
    public Transform bulletPos;
    public GameObject enemyBullet;
    private int stock = 1;
    private float idleTime = 7.0f;
    private float idleBuffer = 0.0f;
    private float timeLim = 1.0f;
    private float timeBuffer = 0.0f;
    private float timeMulti = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.position.x >= 0) hpos *= (-1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -6) Destroy(gameObject);
        else if(hp <= 0)
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + score);
            Destroy(gameObject);
        }
        Move();
        if(stock > 0 && this.transform.position.y < 5) Fire();
        else Idle();
    }

    void Fire()
    {
        timeBuffer += Time.deltaTime * timeMulti;
        if(timeBuffer >= timeLim)
        {
            timeBuffer = 0.0f;
            GameObject bullet = Instantiate(enemyBullet, bulletPos);
            bullet.transform.parent = this.transform.parent;
            stock--;
        }
    }

    void Idle()
    {
        idleBuffer += Time.deltaTime * timeMulti;
        if(idleBuffer >= idleTime)
        {
            idleBuffer = 0.0f;
            stock = 1;
        }
    }

    void Move()
    {
        this.transform.position += new Vector3(Time.deltaTime * hspeed * hpos, Time.deltaTime * vspeed * vpos, 0);
        // -8.4 <-> 8.4 
        if ((this.transform.position.x >= xlim) || (this.transform.position.x <= xlim * (-1.0f))) hpos *= (-1.0f);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag.Equals("playerBullet"))
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + score);
            Destroy(gameObject);
        }
    }

}
