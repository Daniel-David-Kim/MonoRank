using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalViceBossScript : MonoBehaviour
{
    public Transform m1;
    public Transform m2;
    public Transform m3;
    public Transform m4;
    public GameObject BossMissile1;
    public GameObject BossMissile2;
    public GameObject BossMissile3;
    public GameObject BossMissile4;
    private float cycleTerm = 8.0f;
    private float cycleBuffer = 0.0f;
    private int stock = 5;
    private float timeLimit = 1.0f;
    private float timeBuffer = 0.0f;
    public float multiTime = 5.0f;
    public float moveSpeed = -2.0f;
    public float flag = 1.0f;
    public float xlim = 7.65f;
    public int hp = 4000;
    public int score = 400;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y >= 3.7) VMove();
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
            GameObject missile1 = Instantiate(BossMissile1, m1);
            GameObject missile2 = Instantiate(BossMissile2, m2);
            GameObject missile3 = Instantiate(BossMissile3, m3);
            GameObject missile4 = Instantiate(BossMissile4, m4);
            missile1.transform.parent = this.transform.parent;
            missile2.transform.parent = this.transform.parent;
            missile3.transform.parent = this.transform.parent;
            missile4.transform.parent = this.transform.parent;
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
            stock = 7;
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
