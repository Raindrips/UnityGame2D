using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControll : MonoBehaviour {

    Animator animator;
    Camera mCamera;
    Color defaultColor;
    private void Awake() {

        animator = GetComponent<Animator>();
        mCamera = GetComponent<Camera>();
        defaultColor = mCamera.backgroundColor;
    }

    void StartGame() {
        animator.SetTrigger("GameStart");
    }

    // 游戏结束
    public void GameOver() {
        animator.SetTrigger("GameOver");
    }

    // 重新启动
    public void Restart() {

        mCamera.backgroundColor = defaultColor;
    }
}
