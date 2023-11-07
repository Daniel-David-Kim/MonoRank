using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private float speed = 3.3f;
    private float force = 6.0f;
    private Animator anim;
    private bool groundTouch = false;
    public Canvas ClearCanvas;
    public Canvas GameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.Space) && groundTouch)
        {
            Jump();
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log("collision Enter");
        if (c.gameObject.tag.Equals("ground")) groundTouch = true;
        else if(c.gameObject.tag.Equals("enemy"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            this.transform.Find("pop").gameObject.SetActive(true);
            Invoke("GameOver", 1);
        }
    }

    void GameOver()
    {
        Time.timeScale = 0.0f;
        GameOverCanvas.gameObject.SetActive(true);
    }

    void OnCollisionExit2D(Collision2D c)
    {
        Debug.Log("collision Leave");
        if (c.gameObject.tag.Equals("ground")) groundTouch = false;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag.Equals("cookie"))
        {
            c.gameObject.tag = "uncookie";
            c.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            c.gameObject.transform.Find("pop").gameObject.SetActive(true);
        } else if(c.gameObject.tag.Equals("exitdoor"))
        {
            speed = 1.5f;
            Time.timeScale = 0.25f;
            anim.SetTrigger("saygoodbye");
            Invoke("GameClear", 1);
        }
    }

    void GameClear()
    {
        Time.timeScale = 0.0f;
        ClearCanvas.gameObject.SetActive(true);
    }

    void Move()
    {
        this.transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
    }

    void Jump()
    {
        anim.SetBool("playerJump", true);
        Invoke("StopJumpMotion", 1);
        GetComponent<Rigidbody2D>().AddForce(Vector3.up.normalized * force, ForceMode2D.Impulse);
    }

    void StopJumpMotion()
    {
        anim.SetBool("playerJump", false);
    }

}
