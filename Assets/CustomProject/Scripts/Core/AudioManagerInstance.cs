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
                        // ���� AudioManager �� ������ �� �����, ������� ������ ������ � ��������� ��� ��������� AudioManager
                        GameObject audioManagerObject = new GameObject("AudioManager");
                        _instance = audioManagerObject.AddComponent<AudioManager>();
                    }
                }
                return _instance;
            }
        }

        // ��������� ���� ����� �� ������� ������� ��� ��������������� ����� �����
        public void PlayClickSound()
        {
            if (Instance != null)
            {
                Instance.PlayClick();
            }
        }
    }
}