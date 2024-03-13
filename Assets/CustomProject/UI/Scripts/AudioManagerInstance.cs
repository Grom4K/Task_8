using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomProject
{
    public class AudioManagerInstance : MonoBehaviour
    {
        private static AudioManager _instance;

        public static AudioManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<AudioManager>();
                    if (_instance == null)
                    {
                        // Если AudioManager не найден на сцене, создаем пустой объект и добавляем ему компонент AudioManager
                        GameObject audioManagerObject = new GameObject("AudioManager");
                        _instance = audioManagerObject.AddComponent<AudioManager>();
                    }
                }
                return _instance;
            }
        }

        // Вызывайте этот метод из другого скрипта для воспроизведения звука клика
        public void PlayClickSound()
        {
            if (Instance != null)
            {
                Instance.PlayClick();
            }
        }
    }
}