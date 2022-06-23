using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Prototype
{
    public sealed class TaskCardPresenter : MonoBehaviour
    {
        [SerializeField] private Transform content;
        [SerializeField] private Button addCartButton;
        [SerializeField] private Card prefab;

        private void Start()
        {
            addCartButton.onClick.AddListener(AddCard);
        }

        private void AddCard() => InitializeCard(Instantiate(prefab));


        private void InitializeCard(Card card)
        {
            card.transform.SetParent(content);

            card.DeleteBtn.onClick.AddListener(() => DeleteCard(card));
            card.CloneBtn.onClick.AddListener(() => CloneCard(card));
        }

        private void DeleteCard(Card card) => Destroy(card.gameObject);

        private void CloneCard(Card card) => InitializeCard(card.Clone());
    }
}
