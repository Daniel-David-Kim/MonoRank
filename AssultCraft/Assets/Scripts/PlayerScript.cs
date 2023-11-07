using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 5.0f;
    private Animator anim;
    public GameObject BulletObject;
    public Transform Lshot;
    public Transform Rshot;
    public GameObject Bullet;
    private float timeLim = 1.0f;
    private float timeSum = 0f;
    private List<string> enemies = new List<string>() { "asteroid", "enemyBullet", "enemy" };
    public GameObject GameOverScreen;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (GameOverScreen == null) Debug.Log("screen is null!");
        else Debug.Log("not null!");
    }

    void Update()
    {
        Move();
        if (Input.GetKey(KeyCode.Space)) Fire();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        this.transform.position += Vector3.right.normalized * Time.deltaTime * h * speed;
        this.transform.position += Vector3.up.normalized * Time.deltaTime * v * speed;
    }

    void Fire()
    {
        timeSum += Time.deltaTime*20f;
        if (timeSum >= timeLim)
        {
            timeSum = 0f;
            GameObject lbullet = Instantiate(Bullet, Lshot);
            GameObject rbullet = Instantiate(Bullet, Rshot);
            lbullet.transform.parent = BulletObject.transform;
            rbullet.transform.parent = BulletObject.transform;
            anim.SetBool("playerIsFire", true);
            Invoke("CeaseFire", 1);
        }
    }

    void CeaseFire()
    {
        anim.SetBool("playerIsFire", false);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        foreach (string tag in enemies)
            if (c.gameObject.tag.Equals(tag))
                GameOver();
    }

    void GameOver()
    {
        Debug.Log("game over");
        GameOverScreen.SetActive(true);
        Time.timeScale = 0.0f;
        Destroy(gameObject);
    }

}
