using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization.Json;
using System;

[Serializable]
class Member
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
}

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private Member user;
    public Text User;
    public Text Score;

    void Awake()
    {
        Debug.Log("Awake");
        using NamedPipeClientStream client = new NamedPipeClientStream(".", "MonoRankPipe", PipeDirection.In);
        client.Connect();
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Member));
        Member recv = serializer.ReadObject(client) as Member;
        user = recv;
        PlayerPrefs.SetString("userid", user.Id);
        PlayerPrefs.SetInt("maxScore", user.Score);
        // test 
        //PlayerPrefs.SetString("userid", "kmj");
        //PlayerPrefs.SetInt("maxScore", 10);
        //
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Time.timeScale = 1.0f;
        DontDestroyOnLoad(gameObject);
        User.text = user.Name;
        Score.text = $"Score : {score}";
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject[] eat = GameObject.FindGameObjectsWithTag("uncookie");
            score = eat.Length * 10;
            PlayerPrefs.SetInt("score", score);
            Score.text = $"Score : {score}";
        }
        CheckQuitFlag();
    }

    void CheckQuitFlag()
    {
        string flag1 = PlayerPrefs.GetString("quit");
        //string flag2 = PlayerPrefs.GetString("backIntro");
        if(flag1.Equals("true"))
        {
            Debug.Log($"score {score} is saved to Database!");
            PlayerPrefs.DeleteAll();
            Debug.Log("Game Terminated.");
            Application.Quit();
        } 
        
        /*else if(flag2.Equals("true"))
        {
            Debug.Log("Back to intro.");
        }*/
    }

}
