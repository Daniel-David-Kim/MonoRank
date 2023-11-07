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

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0) {
            int totalScore = PlayerPrefs.GetInt("score");
            int maxScore = PlayerPrefs.GetInt("maxScore");
            if (totalScore > maxScore) SaveToDB(totalScore);
            Debug.Log($"result score : {totalScore}");
        }
        PlayerPrefs.SetString("quit", "true");
    }

    // ����Ƽ������ ������, �����̶� �����ϸ� ���� ȭ������ �ȵ��ư��� ���ߴ� ���� �߻��ؼ� ����.
    /*public void BackIntro()
    {
        int totalScore = PlayerPrefs.GetInt("score");
        int maxScore = PlayerPrefs.GetInt("maxScore");
        if (totalScore > maxScore) SaveToDB(totalScore);
        Debug.Log($"result score : {totalScore}");

        PlayerPrefs.SetString("backIntro", "true");
        SceneManager.LoadScene(0);
        Debug.Log($"load scene");
    }*/

    private void SaveToDB(int totalScore)
    {
        string id = PlayerPrefs.GetString("userid");
        string sql = $"update eatcookie set score={totalScore} where id='{id}'"; ;
        using (MySqlConnection conn = new MySqlConnection($"Server={Server};Port={Port};Database={Database};Uid={Uid};Pwd={Pwd}"))
        {
            conn.Open();
            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                int res = command.ExecuteNonQuery();
                if (res == 1) Debug.Log("DBó���� ���������� �Ϸ�Ǿ����ϴ�.");
                else Debug.Log("DBó���� �����Ͽ����ϴ�.");
            }
        }
    }

}
