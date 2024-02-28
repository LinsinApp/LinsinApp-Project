using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DataController : MonoBehaviour
{

    public RoundData[] todasAsRodadas;

    private int rodadaIndex;
    private int playerHighScore;

    //private string gameDataFileName = "data.json";

    // Start is called 
    void Start()
    {

        DontDestroyOnLoad(gameObject);

        //LoadGameData();

        SceneManager.LoadScene("MenGameII");

    }

    // Update is called 
    void Update()
    {

    }

    public void SetRoundData(int round)
    {
        rodadaIndex = round;
    }

    public RoundData GetCurrentRoundData()
    {
        return todasAsRodadas[rodadaIndex];
    }

    //private void LoadGameData()
    //{
    //    string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

    //    if (File.Exists(filePath))
    //    {
    //        string dataAsJson = File.ReadAllText(filePath);
    //        GameData loadeData = JsonUtility.FromJson<GameData>(dataAsJson);
    //        todasAsRodadas = loadeData.todasAsRodadas;
    //    }
    //    else
    //    {
    //        Debug.LogError("Não foi possivel carregar os dados!");
    //    }
    //}

    public void EnviarNovoHighScore(int newScore)
    {
        if (newScore > playerHighScore)
        { 
            playerHighScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighScore()
    { 
        return playerHighScore;
    }

    private void LoadPlayerProgress() 
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            playerHighScore = PlayerPrefs.GetInt("highScore");
        }
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highScore", playerHighScore);
    }
}