using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class healthUI : MonoBehaviour
    {
        public TankHealth TH;
        public Slider m_Slider;                             // The slider to represent how much health the tank currently has.
        public Image m_FillImage;                           // The image component of the slider.
        public Color m_FullHealthColor = Color.green;       // The color the health bar will be when on full health.
        public Color m_ZeroHealthColor = Color.red;         // The color the health bar will be when on no health.

        private void Awake()
        {
            TH.onLifeChanged += HandlerLifeChanged;
        }

        private void OnDestroy()
        {
            TH.onLifeChanged -= HandlerLifeChanged;
        }

        void HandlerLifeChanged(float actual, float total) {
            // Set the slider's value appropriately.
            m_Slider.value = actual;

            // Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
            m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, actual / total);
        }
    }
}