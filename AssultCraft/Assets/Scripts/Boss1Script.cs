using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Boss1Script : MonoBehaviour
{
    private int hp = 2000;
    private float speed = -1.0f;
    public Transform Cshot;
    public GameObject EnemyBullet;
    private int rep = 2;
    private int stock = 4;
    private float timeLimit = 0.8f;
    private float timeBuf = 0.0f;
    private int score = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (rep > 0 || stock > 0) Fire();
        if (this.transform.position.y <= -8) Destroy(gameObject);
        else if (hp <= 0)
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + score);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log("bullet collision!");
        if (c.gameObject.tag.Equals("playerBullet"))
        {
            int dmg = c.gameObject.GetComponent<PlayerBulletScript>().damage;
            Debug.Log("enemy damaged : " + dmg);
            hp -= dmg;
            Destroy(c.gameObject);
        }

    }

    void Move()
    {
        this.transform.position += new Vector3(0, Time.deltaTime * speed, 0);
    }

    void Fire()
    {
        timeBuf += Time.deltaTime * 1.0f;
        if (timeBuf >= timeLimit)
        {
            timeLimit = 0.8f;
            timeBuf = 0.0f;
            GameObject bullet = Instantiate(EnemyBullet, Cshot);
            bullet.transform.parent = this.transform.parent;
            stock--;
            if(stock <- 0 && rep > 0)
            {
                timeLimit = 3.0f;
                rep--;
                stock = 7;
            }
        }
    }

}
