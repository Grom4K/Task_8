using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomProject
{
    [RequireComponent(typeof(Button))]
    public class SfxButton : MonoBehaviour
    {
        #region Private Variables

        private Button _button;

        #endregion


        #region Unity Callbacks

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Click);
        }

        #endregion
        
        #region Pritave Methods

        private void Click()
        {
            AudioManagerInstance.Instance.PlayClick();
        }

        #endregion
    }
}

