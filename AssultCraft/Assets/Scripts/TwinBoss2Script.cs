using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinBoss2Script : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public GameObject BossPhoton1;
    public GameObject BossPhoton2;
    public GameObject BossPhoton3;
    private float cycleTerm = 2.0f;
    private float cycleBuffer = 0.0f;
    private int stock = 4;
    private float timeLimit = 2.4f;
    private float timeBuffer = 0.0f;
    public float multiTime = 5.0f;
    public float moveSpeed = -2.0f;
    public float flag = 1.0f;
    public float xlim = 7.89f;
    public int hp = 3000;
    public int score = 300;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y >= 3.8) VMove();
        else HMove();
        if (stock > 0) Fire();
        else IdleTerm();
        if (this.transform.position.y <= -8) Destroy(gameObject);
        else if (hp <= 0)
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + score);
            Destroy(gameObject);
        }
    }

    void VMove()
    {
        this.transform.position += new Vector3(0, Time.deltaTime * moveSpeed, 0);
    }

    void HMove()
    {
        this.transform.position += new Vector3(Time.deltaTime * moveSpeed * flag, 0, 0);
        float x = this.transform.position.x;
        if ((x >= xlim) || (x <= xlim * (-1))) flag *= -1.0f;
    }

    void Fire()
    {
        moveSpeed = 0.0f;
        timeBuffer += Time.deltaTime * multiTime;
        if (timeBuffer >= timeLimit)
        {
            timeBuffer = 0.0f;
            GameObject photon1 = Instantiate(BossPhoton1, p1);
            GameObject photon2 = Instantiate(BossPhoton2, p2);
            GameObject photon3 = Instantiate(BossPhoton3, p3);
            photon1.transform.parent = this.transform.parent;
            photon2.transform.parent = this.transform.parent;
            photon3.transform.parent = this.transform.parent;
            stock--;
        }
    }

    void IdleTerm()
    {
        moveSpeed = -2.0f;
        cycleBuffer += Time.deltaTime * multiTime;
        if (cycleBuffer >= cycleTerm)
        {
            cycleBuffer = 0.0f;
            timeBuffer = 0.0f;
            stock = 4;
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag.Equals("playerBullet"))
        {
            hp -= c.gameObject.GetComponent<PlayerBulletScript>().damage;
            Debug.Log("hp : " + hp);
            Destroy(c.gameObject);
        }
    }

}
