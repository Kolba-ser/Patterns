using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Patterns.Strategy
{
    public sealed class MovementButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textContent;
        [SerializeField] private Button button;

        public event UnityAction Change
        {
            add
            {
                Assert.IsNotNull(button, "Button is not defined");
                button.onClick.AddListener(value);
            }
            remove
            {

                Assert.IsNotNull(button, "Button is not defined");
                button.onClick.RemoveListener(value);
            }
        }

        public void SetContent(string text)
        {
            textContent.text = text;
        }
    }
}
