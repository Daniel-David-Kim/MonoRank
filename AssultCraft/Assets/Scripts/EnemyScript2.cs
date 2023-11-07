using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
{
    private int hp = 100;
    private float speed = -1.0f;
    public Transform p1;
    public Transform p2;
    public GameObject EnemyPhoton1;
    public GameObject EnemyPhoton2;
    public int stock = 7;
    public float timeLimit = 1.0f;
    private float timeBuf = 0.0f;
    private int score = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (stock > 0) Fire();
        if (this.transform.position.y <= -6) Destroy(gameObject);
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
            timeBuf = 0.0f;
            GameObject photon1 = Instantiate(EnemyPhoton1, p1);
            GameObject photon2 = Instantiate(EnemyPhoton2, p2);
            photon1.transform.parent = this.transform.parent;
            photon2.transform.parent = this.transform.parent;
            stock--;
        }
    }

}
