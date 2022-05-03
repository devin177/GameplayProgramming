using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class RainMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            GameObject newGameObject = Instantiate(this.prefab, new Vector3(0,0,0), Quaternion.identity);
            Destroy(newGameObject, 5.0f);
            return newGameObject;
        }
    }
}
