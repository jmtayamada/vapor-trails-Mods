﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadspaceController : MonoBehaviour {
    Vector2 lastPlayerPos;
    Animator animator;
    Animator playerAnimator;
    string lastScene;

    void Start() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (lastScene != null) {
            FinishLeavingHeadspace();
        }
    }

    void StartEnterHeadspaceAnimation () {
        lastScene = SceneManager.GetActiveScene().path;
        animator.SetTrigger("EnterHeadspace");
    }

    // called from animation
    public void EnterHeadspace () {
        GlobalController.LoadScene("Headspace/Headspace", Beacon.A);
    }

    public void LeaveHeadspace() {
        SceneManager.LoadScene(lastScene);
    }

    public void FinishLeavingHeadspace() {
        lastScene = null;
        GlobalController.MovePlayerTo(lastPlayerPos);
    }
}
