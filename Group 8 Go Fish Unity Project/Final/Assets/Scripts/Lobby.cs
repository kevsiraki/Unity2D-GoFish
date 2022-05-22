using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GoFish {
    public class Lobby : MonoBehaviour {
		public enum LobbyState {
            Default,
            JoinedRoom,
        }
        public LobbyState State = LobbyState.Default; //for SP
        public void OnPracticeClicked() { /// Practice button was clicked.
            Debug.Log("OnPracticeClicked");
            SceneManager.LoadScene("GameScene");
        }
    }
}