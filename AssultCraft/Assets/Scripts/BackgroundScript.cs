using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private float speed = 0.2f;
    void Update()
    {
        GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", Vector2.up.normalized * speed * Time.time);
    }
}
