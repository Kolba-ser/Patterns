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
            for (int i = 0; i < Tiers; i++)
            {
                if(creators[Random.Range(0, length)].TryCreate(out Product product))
                {
                    product.transform.position = new Vector3(transform.position.x,
                                                    transform.position.y + height + product.GetSize().y / 2,
                                                    transform.position.z);
                    height += product.GetSize().y;
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
