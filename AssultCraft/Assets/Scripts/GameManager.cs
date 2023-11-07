using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO.Pipes;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization.Json;

[Serializable]
class Member
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
}

public class GameManager : MonoBehaviour
{
    private GameObject[] enemies;
    private GameObject[] bosses;
    private GameObject[] asteroids;
    private Member user;
    public Text Player;
    public Text ScoreTitle;
    //private string player = "플레이어1";
    private GameManager gm;

    void Awake()
    {
        UnityEngine.Debug.Log("Awake");
        PlayerPrefs.SetInt("totalScore", 0);
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

    void Start()
    {
        UnityEngine.Debug.Log("Start");
        

        Player.text = $"Player : {user.Name}";
        ScoreTitle.text = $"SCORE : {PlayerPrefs.GetInt("totalScore")}";
        
        //UnityEngine.Debug.Log($"Player : {user.Name}, Score : {PlayerPrefs.GetInt("totalScore")}");
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            ScoreTitle.text = $"SCORE : {PlayerPrefs.GetInt("totalScore")}";
            //UnityEngine.Debug.Log($"Player : {Player}, Score : {PlayerPrefs.GetInt("totalScore")}");
            enemies = GameObject.FindGameObjectsWithTag("enemy");
            bosses = GameObject.FindGameObjectsWithTag("boss");
            asteroids = GameObject.FindGameObjectsWithTag("asteroid");
            if (enemies.Length == 0 && bosses.Length == 0 && asteroids.Length == 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        CheckFlag();
    }

    void CheckFlag()
    {
        string flag = PlayerPrefs.GetString("quit");
        if(flag.Equals("true"))
        {
            UnityEngine.Debug.Log("DB에 결과가 반영되었습니다.");
            PlayerPrefs.DeleteAll();
            Application.Quit();
        }
    }

}