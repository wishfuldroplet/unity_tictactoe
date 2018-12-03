﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WishfulDroplet;


[CreateAssetMenu(fileName = "TicTacToeScreen", menuName = "TicTacToe/GameState/TicTacToeScreen")]
public class TicTacToeScreen : GameState {
	[SerializeField] private SceneReference _ticTacToeScene;


	public override void OnEnter(IState prevState) {
		SceneManager.LoadSceneAsync(_ticTacToeScene.SceneName, LoadSceneMode.Single);
	}

	public override void OnExit(IState nextState) {
		//SceneManager.UnloadSceneAsync(_ticTacToeScene.SceneName);
	}
}