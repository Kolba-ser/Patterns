using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Patterns.FactoryMethod
{
    public sealed class RandomStack : Stack
    {
        [SerializeField] private List<Creator> creators;

        protected override void Create()
        {
            int length = creators.Count;
            float currentHeight = 0;
            for (int i = 0; i < Tiers; i++)
            {
                if(creators[Random.Range(0, length)].TryCreate(out Product product))
                {
                    Debug.Log(Random.Range(0, length));
                    currentHeight += product.GetSize().y;
                    product.transform.position = new Vector3(transform.position.x,
                                                    transform.position.y + currentHeight,
                                                    transform.position.z);
                    product.transform.SetParent(transform);
                }
                else
                {
                    Debug.Log($"Run out of money in the {GetType()}");
                    return;
                }
            }
        }
    }
}
