using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Prototype
{
    public abstract class Card : MonoBehaviour
    {
        [SerializeField] private Button cloneBtn;
        [SerializeField] private Button deleteBtn;

        public Button CloneBtn => cloneBtn;
        public Button DeleteBtn => deleteBtn;

        public abstract Card Clone();
    }
}
