using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace CustomProject
{
    public class SceneLoad : MonoBehaviour
    {
        [SerializeField] private int _indexLoadScene;

        private void Start()
        {
            StartCoroutine(LoadSceneCoroutine());
        }

        IEnumerator LoadSceneCoroutine()
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(_indexLoadScene);
            asyncOperation.allowSceneActivation = false;
            while (asyncOperation.progress < 0.9f)
            {
                float progress = asyncOperation.progress / 0.9f;
                yield return null;
            }

            asyncOperation.allowSceneActivation = true;
        }
    }
}
