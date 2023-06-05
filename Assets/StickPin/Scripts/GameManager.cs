using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager _instace;
    public static GameManager instace {
        get => _instace;
    }

    public CameraControll cameraControll;

    public TMP_Text meshProScore;
  

    public int fireCount = 0;
    public int lastCount = 0;
    void Awake()
    {
        _instace = this;
    }

    void Update()
    {
        
    }


    public void LinkSuccess() {
        fireCount++;
        meshProScore.text = fireCount.ToString();
    }

    public void GameOver() {
        if (cameraControll) {
            cameraControll.GameOver();
        }
        Invoke("ResetGame", 1);
        
    }

    public void ResetGame() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    
    
}
