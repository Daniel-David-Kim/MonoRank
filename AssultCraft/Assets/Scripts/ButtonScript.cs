using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;

public class ButtonScript : MonoBehaviour
{
    private const string Server = "localhost";
    private const int Port = 3306;
    private const string Database = "monorank";
    private const string Uid = "root";
    private const string Pwd = "1234";

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void GameQuit()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            int totalScore = PlayerPrefs.GetInt("totalScore");
            int maxScore = PlayerPrefs.GetInt("maxScore");
            if (totalScore > maxScore) SaveToDB(totalScore);
            Debug.Log($"result score : {totalScore}");
        }
        PlayerPrefs.SetString("quit", "true");
    }

    // 유니티에서는 정상 동작하지만 윈폼에서 연동하면 멈춤 발생.
    /*public void ResumeGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }*/

    private void SaveToDB(int totalScore)
    {
        string id = PlayerPrefs.GetString("userid");
        string sql = $"update assaultcraft set score={totalScore} where id='{id}'"; ;
        using (MySqlConnection conn = new MySqlConnection($"Server={Server};Port={Port};Database={Database};Uid={Uid};Pwd={Pwd}"))
        {
            conn.Open();
            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                int res = command.ExecuteNonQuery();
                if (res == 1) Debug.Log("DB처리가 정상적으로 완료되었습니다.");
                else Debug.Log("DB처리에 실패하였습니다.");
            }
        }
    }

}
