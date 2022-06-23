using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Prototype
{
    public sealed class TaskCard : Card
    {


        public override Card Clone() => Instantiate(this);

        private void OnDestroy()
        {
            CloneBtn.onClick.RemoveAllListeners();
            DeleteBtn.onClick.RemoveAllListeners();
        }
    }
}
